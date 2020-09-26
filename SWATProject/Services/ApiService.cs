using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SWATProject.Interfaces;
using SWATProject.Models;
using Xamarin.Essentials;

namespace SWATProject.Services
{
    public class ApiService : IRestInterface
    {


        public async Task<List<Event>> GetEvents()
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", Preferences.Get("accesstoken", ""));
            var response = await httpClient.GetStringAsync("enter api url");
            var result = JsonConvert.DeserializeObject<List<Event>>(response);
            return result;

        }


        public async Task<TokenResponse> GetToken(string email, string password)
        {


            var loginModel = new User()
            {
                Email = email,
                Password = password,

            };

            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(loginModel);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("enter api url", content);

            var jsonResult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<TokenResponse>(jsonResult);

            return result;

        }

        public async Task<bool> RegisterUser(string email, string password, string confirmPassword)
        {

            var registerModel = new User()
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(registerModel);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var respones = await httpClient.PostAsync("enter api url", content);

            return respones.IsSuccessStatusCode;

        }
    }
}
