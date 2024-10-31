namespace BookManagerGraphQL.Domain.Interfaces;

public interface IUoW
{
    Task<bool> Complete();
}