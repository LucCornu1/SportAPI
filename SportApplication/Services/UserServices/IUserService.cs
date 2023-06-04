using SportApplication.Models;

namespace SportApplication.Services.UserServices
{
    public interface IUserService
    {
        List<User> GetUsers();
        User? GetUser(string email);
        List<User> AddUser(User newUser);
        User? UpdateUser(string email, User updatedUser);
        bool DeleteUser(string email);
    }
}
