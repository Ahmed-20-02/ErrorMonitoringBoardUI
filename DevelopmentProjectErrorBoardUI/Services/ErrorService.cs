using System.Text;

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
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetAllErrors")
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
        
        public async Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusModel model/*int errorId, int statusId, int agentId*/)
        {
            try
            {
                var updateRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/UpdateErrorStatus"),
                    Content = new StringContent(JsonConvert.SerializeObject(/*new UpdateErrorStatusModel{ErrorId = errorId, StatusId = statusId/*, AgentId = 3, CustomerId = 4, DevId = 2#1#}*/ model), Encoding.UTF8, "application/json")
                };

                var updateResult = await _http.SendAsync(updateRequestMessage);

                var updateResultContent = await updateResult.Content.ReadAsStringAsync();
                var updatedError = JsonConvert.DeserializeObject<ErrorModel>(updateResultContent);
                
                var getRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetAllErrors")
                };

                var getResult = await _http.SendAsync(getRequestMessage);

                var getResultContent = await getResult.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ErrorAndPathModel>>(getResultContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}