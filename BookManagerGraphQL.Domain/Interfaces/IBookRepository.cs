using BookManagerGraphQL.Domain.Entities;

namespace BookManagerGraphQL.Domain.Interfaces;

public interface IBookRepository
{
    void AddBook(Book book);
    void UpdateBook(Book book);
    bool DeleteBook(Book book);
    Task<IEnumerable<Book>> GetAllBooksAsync();
    Task<Book> GetBookByIdAsync(int id);
    Task<IEnumerable<Book>> SearchBooksByTitleAsync(string title);
    Task<IEnumerable<Book>> FilterBooksByGenreAsync(string genre);
    Task<IEnumerable<Book>> GetSortedBooksAsync(string sortBy);
    Task<Book> GetRandomBookAsync();
    Task<IEnumerable<Book>> GetPaginatedBooksAsync(int pageNumber, int pageSize);
    Task<Status> UpdateBookStatusAsync(int id, bool isAvailable);
    Task<IEnumerable<Reviews>> GetReviewsForBookAsync(int bookId);
    Task<Reviews> UpdateBookRatingAsync(int bookId, double rating);
}