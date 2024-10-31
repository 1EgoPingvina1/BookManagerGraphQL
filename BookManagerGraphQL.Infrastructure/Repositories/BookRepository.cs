using BookManagerGraphQL.Domain.Entities;
using BookManagerGraphQL.Domain.Interfaces;
using BookManagerGraphQL.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookManagerGraphQL.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookContext _context;

    public BookRepository(BookContext context)
    {
        _context = context;
    }

    public void AddBook(Book book) => _context.Add(book);

    public void UpdateBook(Book book) => _context.Update(book);

    public bool DeleteBook(Book book)
    {
        var result = _context.Remove(book);
        if (result.State == EntityState.Deleted)
        {
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync() => await _context.Books.ToListAsync(); 

    public async Task<Book?> GetBookByIdAsync(int id) => await _context.Books.SingleOrDefaultAsync(x => x.Id == id);
    
    public async Task<IEnumerable<Book>> SearchBooksByTitleAsync(string title) => await _context.Books.Where(b => b.Title.Contains(title)).ToListAsync(); 

    public async Task<IEnumerable<Book>> FilterBooksByGenreAsync(string genre) => await _context.Books.Where(b => b.Genre == genre).ToListAsync(); 

    public async Task<IEnumerable<Book>> GetSortedBooksAsync(string sortBy)
    {
        IQueryable<Book> query = _context.Books;
        query = sortBy switch
        {
            "Title" => query.OrderBy(b => b.Title),
            "Genre" => query.OrderBy(b => b.Genre),
            "Author" => query.OrderBy(b => b.Author),
            "Date" => query.OrderBy(b => b.CreatedAt)
        };
        return await query.ToListAsync();
    }
    
    public async Task<Book> GetRandomBookAsync()
    {
        var countBookInLibrary = await _context.Books.CountAsync();
        var randomIndex = new Random().Next(0, countBookInLibrary);
        return await _context.Books.Skip(randomIndex).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Book>> GetPaginatedBooksAsync(int pageNumber, int pageSize)
        => await _context.Books
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(); 

    public async Task<Status> UpdateBookStatusAsync(int id, bool isAvailable)
    {
        var book = await _context.Books.Include(x => x.Status).SingleOrDefaultAsync(x => x.Id == id);
        if (book is not null)
            book.StatusId = isAvailable 
                ? (await _context.Statuses.SingleOrDefaultAsync(x => x.Name == "Availible")).Id 
                : (await _context.Statuses.SingleOrDefaultAsync(x => x.Name == "InExchange")).Id;
        return book.Status;
    }
    
    public async Task<IEnumerable<Reviews>> GetReviewsForBookAsync(int bookId) 
        => await _context.Reviews.Where(x => x.BookId == bookId).ToListAsync(); 

    public async Task<Reviews> UpdateBookRatingAsync(int bookId, double rating)
    {
        var review = await _context.Reviews.SingleOrDefaultAsync(x => x.Id == bookId);
        review.Rating = rating;
        _context.Update(review);
        return review;
    }
}