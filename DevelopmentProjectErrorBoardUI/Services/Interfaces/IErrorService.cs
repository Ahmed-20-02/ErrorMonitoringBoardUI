namespace DevelopmentProjectErrorBoardUI.Services.Interfaces
{
    using DevelopmentProjectErrorBoardUI.Models;

    public interface IErrorService
    {
        Task<List<ErrorAndPathModel>> GetAllErrorsAsync();
        Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusModel model);
        Task<List<ErrorAndPathModel>> UpdateErrorsAssignedDeveloperAsync(UpdateErrorsAssignedDeveloperModel model);

        Task<DevCheckLogInModel> LogInAsync(LogInModel model);
        Task<List<UserModel>> GetDevelopersAsync();
    }
}