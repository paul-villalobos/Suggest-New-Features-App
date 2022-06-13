using SuggestionAppLibrary.Models;

namespace SuggestionAppLibrary.DataAccess
{
   public interface IUserData
   {
      Task CreateUser(UserModel user);
      Task<UserModel> GetUser(string id);
      Task<UserModel> GetUserFromAuthenticationAsync(string objectId);
      Task<List<UserModel>> GetUsersAsync();
      Task UpdateUser(UserModel user);
   }
}