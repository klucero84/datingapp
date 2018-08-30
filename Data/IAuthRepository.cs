using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    /// <summary>
    /// Authorization Repository Interface for dating app api
    /// </summary>
    public interface IAuthRepository
    {
        /// <summary>
        /// Registration process, adds user to the application
        /// </summary>
        /// <param name="user">a unique name for the user</param>
        /// <param name="password">password for the user</param>
        /// <returns></returns>
         Task<User> Register(User user, string password);

        /// <summary>
        /// Login process
        /// </summary>
        /// <param name="username">username to authorize</param>
        /// <param name="password">password to authenticate</param>
        /// <returns></returns>
         Task<User> Login(string username, string password);

        /// <summary>
        /// Checks to see if a user exists, used in registration to ensure unique username
        /// </summary>
        /// <param name="username">proposed username</param>
        /// <returns>an async operation returning a bool, true = user exisit</returns>
         Task<bool> UserExists(string username);
    }
}