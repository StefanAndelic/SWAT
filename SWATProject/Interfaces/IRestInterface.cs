using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SWATProject.Models;

namespace SWATProject.Interfaces
{
    public interface IRestInterface
    {
        Task<bool> RegisterUser(string email, string password, string confirmPassword);

        Task<TokenResponse> GetToken(string email, string password);

        Task<List<Event>> GetEvents();
    }
}
