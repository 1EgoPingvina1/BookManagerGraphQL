using BookManagerGraphQL.Domain.Entities;
using BookManagerGraphQL.Domain.Interfaces;

namespace BookManagerGraphQL.Domain.Services;

public class UserService
{
    private readonly IBookRepository _bookRepository;
    public UserService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public async Task<IEnumerable<Book>> GetAllBooks() => await _bookRepository.GetAllBooksAsync();
}