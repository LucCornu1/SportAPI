using SportApplication.Models;

namespace SportApplication.Services.UserServices
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>
        {
            new User { Email = "firstuser@example.com", Firstname = "First", Lastname = "User" },
            new User { Email = "seconduser@example.com", Firstname = "Second", Lastname = "User" },
        };

        public List<User> AddUser(User newUser)
        {
            users.Add(newUser);

            return users;
        }

        public bool DeleteUser(string email)
        {
            var user = users.Find(x => x.Email.Equals(email));

            if (user == null)
            {
                return false;
            }

            return users.Remove(user);
        }

        public User? GetUser(string email)
        {
            var user = users.Find(x => x.Email.Equals(email));

            return user;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public User? UpdateUser(string email, User updatedUser)
        {
            var user = users.Find(x => x.Email.Equals(email));

            if (user == null)
            {
                return null;
            }

            user.Email = updatedUser.Email;
            user.Firstname = updatedUser.Firstname;
            user.Lastname = updatedUser.Lastname;
            user.Password = updatedUser.Password;
            user.Gender = updatedUser.Gender;
            user.Birthdate = updatedUser.Birthdate;

            return user;
        }
    }
}
