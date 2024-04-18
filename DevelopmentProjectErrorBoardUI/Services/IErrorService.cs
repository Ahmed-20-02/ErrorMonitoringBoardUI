namespace DevelopmentProjectErrorBoardUI.Services
{
    using DevelopmentProjectErrorBoardUI.Models;

    public interface IErrorService
    {
        Task<List<ErrorAndPathModel>> GetAllErrorsAsync();
        Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusModel model);
        Task<DevCheckLogInModel> LogInAsync(LogInModel model);
    }
}