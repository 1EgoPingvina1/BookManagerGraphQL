using BookManagerGraphQL.Domain.Entities;

namespace BookManagerGraphQL.Domain.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers();
    Task<User> GetUserById(int id);
    Task<User> GetUserByEmail(string email);
}