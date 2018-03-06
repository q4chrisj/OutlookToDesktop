using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace OutlookToDesktop.ApiService
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResultModel> Authenticate();
        AuthenticationResultModel AuthenitcationResult { get; set; }
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly string _authenticationEndpoint;
        private readonly string _email;
        private readonly string _password;

        public AuthenticationService(string desktopDomain, string email, string password)
        {
            _authenticationEndpoint = String.Concat(desktopDomain, "/api/auth");
            _email = email;
            _password = password;
        }

        public AuthenticationResultModel AuthenitcationResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<AuthenticationResultModel> Authenticate()
        {
            HttpClient client = new HttpClient();

            var values = new Dictionary<string, string>
            {
                { "user", _email },
                { "password", _password },
                { "product", "desktop" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(_authenticationEndpoint, content);

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<AuthenticationResultModel>(responseString);

            return result;
        }
    }
}
