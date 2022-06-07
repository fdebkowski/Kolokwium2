using ABPD10.Entities;

namespace ABPD10.Services;

public interface IUsersDbService
{
    Task<User> GetUserAsync(string username);
}