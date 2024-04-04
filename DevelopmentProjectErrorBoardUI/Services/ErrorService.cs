using System.Net;
using DevelopmentProjectErrorBoardUI.Models;

namespace DevelopmentProjectErrorBoardUI.Services
{

    using System.Net.Http.Json;

    public class ErrorService : IErrorService
    {
        private readonly HttpClient _http;

        public ErrorService(HttpClient http)
        {
            _http = http;
        }

        /*public List<User> Users { get; set; } = new List<User>();

        public async Task GetServices()
        {
            var result = await _http.GetFromJsonAsync<List<Service>>("api/user/services");
            if (result != null)
            {
                services = result;
            }
        }*/
        
       // private static readonly HttpClient client = new HttpClient();

        public async Task<IEnumerable<ErrorAndPathModel>> GetAsync(string endpoint)
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://api.clickatell.com/rest/message"),
                    Headers = { 
                     //   { HttpRequestHeader.Authorization.ToString(), "Bearer xxxxxxxxxxxxxxxxxxx" },
                        { HttpRequestHeader.Accept.ToString(), "application/json" },
                     //   { "X-Version", "1" }
                    },
                   // Content = new StringContent(JsonConvert.SerializeObject(svm))
                };

                var response = _http.SendAsync(httpRequestMessage).Result;
                
                var debugtest = await _http.GetFromJsonAsync<ErrorAndPathModel[]>("GetErrors/GetAllErrors" /*"https://api.thecatapi.com/v1/images/0XYvRd7oD"*/);
                // var response = _http.GetAsync(endpoint).Result;
                return debugtest;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}