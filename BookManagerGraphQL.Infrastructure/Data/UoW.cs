using BookManagerGraphQL.Domain.Interfaces;

namespace BookManagerGraphQL.Infrastructure.Data;

public class UoW : IUoW
{
    private readonly BookContext _context;

    public UoW(BookContext context) => _context = context;
    
    public async Task<bool> Complete() => await _context.SaveChangesAsync() > 0;
}