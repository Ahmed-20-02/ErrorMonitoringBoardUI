namespace DevelopmentProjectErrorBoardUI.Services.Interfaces
{
    using DevelopmentProjectErrorBoardUI.Resources.Models;
    using DevelopmentProjectErrorBoardUI.Resources.Requests;
    
    public interface IErrorService
    {
        Task<List<ErrorAndPathModel>> GetErrorsAsync();
        Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusRequest request);
        Task<List<ErrorAndPathModel>> DeactivateError(DeactivateErrorRequest request);
        Task<List<ErrorAndPathModel>> UpdateErrorsAssignedDeveloperAsync(UpdateErrorsAssignedDeveloperRequest request);
        Task<DevCheckLogInRequest> LogInAsync(LogInModelRequest modelRequest);
        Task<List<UserModel>> GetDevelopersAsync();

        Task<List<ProjectModel>> GetProjectsAsync();

    }
}