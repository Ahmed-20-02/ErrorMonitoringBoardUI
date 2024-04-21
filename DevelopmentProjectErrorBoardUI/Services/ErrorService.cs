namespace DevelopmentProjectErrorBoardUI.Services
{
    using System.Text;
    using DevelopmentProjectErrorBoardUI.Services.Interfaces;
    using DevelopmentProjectErrorBoardUI.Models;
    using Newtonsoft.Json;
    public class ErrorService : IErrorService
    {
        private readonly HttpClient _http;

        public ErrorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ErrorAndPathModel>> GetErrorsAsync()
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetErrors")
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
        
        public async Task<List<UserModel>> GetDevelopersAsync()
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetDevelopers")
                };

                var result = await _http.SendAsync(httpRequestMessage);

                var resultContent = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<UserModel>>(resultContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public async Task<List<ProjectModel>> GetProjectsAsync()
        {
            try
            {
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetProjects")
                };

                var result = await _http.SendAsync(httpRequestMessage);

                var resultContent = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ProjectModel>>(resultContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public async Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusModel model)
        {
            try
            {
                var updateRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/UpdateErrorStatus"),
                    Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json")
                };

                var updateResult = await _http.SendAsync(updateRequestMessage);

                await updateResult.Content.ReadAsStringAsync();
                
                var getRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetErrors")
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
        
        public async Task<List<ErrorAndPathModel>> DeactivateError(DeactivateErrorModel model)
        {
            try
            {
                var deactivateRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/DeactivateError"),
                    Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json")
                };

                await _http.SendAsync(deactivateRequestMessage);
                
                var getRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetErrors")
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
        
        public async Task<List<ErrorAndPathModel>> UpdateErrorsAssignedDeveloperAsync(UpdateErrorsAssignedDeveloperModel model)
        {
            try
            {
                var updateRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/UpdateErrorsAssignedDeveloper"),
                    Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json")
                };

                var updateResult = await _http.SendAsync(updateRequestMessage);

                await updateResult.Content.ReadAsStringAsync();
                
                var getRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/GetErrors")
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
        
        public async Task<DevCheckLogInModel> LogInAsync(LogInModel model)
        {
            try
            {
                var logInRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri($"{_http.BaseAddress.ToString()}Errors/DevLogIn"),
                    Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json")
                };

                var logInResult = await _http.SendAsync(logInRequestMessage);

                var updateResultContent = await logInResult.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DevCheckLogInModel>(updateResultContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}