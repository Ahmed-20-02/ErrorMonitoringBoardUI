namespace DevelopmentProjectErrorBoardUI.Services
{
    using DevelopmentProjectErrorBoardUI.Models;
    using Newtonsoft.Json;
    public class ErrorService : IErrorService
    {
        private readonly HttpClient _http;

        public ErrorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ErrorAndPathModel>> GetAllErrorsAsync()
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}GetErrors/GetAllErrors")
                };

                var result = await _http.SendAsync(httpRequestMessage);

                var resultContent = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ErrorAndPathModel>>(resultContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}