using BookManagerGraphQL.Domain.Entities;
using BookManagerGraphQL.Domain.Interfaces;
using BookManagerGraphQL.Domain.Services;

namespace BookManagerGraphQL.API.GraphQL.Queries;

public class BookQuery
{
    public async Task<IEnumerable<Book>> GetBooksAsync([Service] IBookRepository _bookRepository)
        => await _bookRepository.GetAllBooksAsync();
    
    public async Task<Book?> GetBookByIdAsync([Service] IBookRepository _bookRepository,int id) => await _bookRepository.GetBookByIdAsync(id);
    
    public async Task<IEnumerable<Book>> SearchBooksByTitleAsync([Service] IBookRepository _bookRepository,string title) => await _bookRepository.SearchBooksByTitleAsync(title); 
    
    public async Task<IEnumerable<Book>> FilterBooksByGenreAsync([Service] IBookRepository _bookRepository,string genre) => await _bookRepository.FilterBooksByGenreAsync(genre);
    
    public async Task<IEnumerable<Book>> GetSortedBookAsync([Service] IBookRepository _bookRepository,string sortBy) => await _bookRepository.GetSortedBooksAsync(sortBy);
    
    public async Task<Book> GetRandomBookAsync([Service] IBookRepository _bookRepository) => await _bookRepository.GetRandomBookAsync();
    
    public async Task<IEnumerable<Book>> GetPaginatedBooksAsync([Service] IBookRepository _bookRepository,int pageNumber, int pageSize)
     => await _bookRepository.GetPaginatedBooksAsync(pageNumber, pageSize);
    
    public async Task<IEnumerable<Reviews>> GetReviewsForBookAsync([Service] IBookRepository _bookRepository,int bookId)
        => await _bookRepository.GetReviewsForBookAsync(bookId);
    
}