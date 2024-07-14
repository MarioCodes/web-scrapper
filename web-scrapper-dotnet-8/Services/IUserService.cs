using webscrapper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace webscrapper.Services
{
    public interface IUserService
    {
        public Task<ResponseListUserModel> GetUsers();

        public Task<ResponseUserModel> GetSpecificUser(RequestUserModel userModel);

        public Task<string> CreateUser(RequestUserModel userModel);

        public Task<string> UpdateUser(RequestUserModel userModel);

        public Task DeleteUsers(List<RequestUserModel> userModel);

        public Task<string> GetRegex();
    }
}
