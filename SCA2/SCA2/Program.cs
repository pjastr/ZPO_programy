using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SCA2
{
    //kod ze strony http://itcraftsman.pl/uzyteczne-koncepty-projektowe-kiss-dry-yagni-tda-oraz-separation-of-concerns/
    class Program
    {
        static void Main(string[] args)
        {
        }


    }

    public interface IUserService
    {
        void RegisterUser(ICollection<User> users, User _user);
        User FindUserByEmail(ICollection<User> users, string email);
    }

    public interface IActivityService
    {
        void LogActivity(User _user, string pathToLog);
    }

    public interface IValidationService
    {
        bool ValidateUserCredentials(ICollection<User> users, User _user);
    }

    public class ActivityService : IActivityService
    {
        public void LogActivity(User _user, string pathToLog)
        {
            using (StreamWriter sw = new StreamWriter(pathToLog))
            {
                sw.WriteLine("Currently {0} {1} activity in at {2}", _user.Email, _user.Password, DateTime.UtcNow);
            }
        }
    }

    public class ValidationService : IValidationService
    {
        public bool ValidateUserCredentials(ICollection<User> users, User _user)
        {
            UserService _userService = new UserService();

            var getCurrentUser = _userService.FindUserByEmail(users, _user.Email);

            if (getCurrentUser != null)
            {
                if (getCurrentUser.Email == _user.Email && getCurrentUser.Password == _user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    public class UserService : IUserService
    {
        public User FindUserByEmail(ICollection<User> users, string email)
        {
            return users.ToList().Where(n => n.Email == email).Single();
        }

        public void RegisterUser(ICollection<User> users, User _user)
        {
            users.Add(_user);
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
