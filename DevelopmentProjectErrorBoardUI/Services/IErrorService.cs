namespace DevelopmentProjectErrorBoardUI.Services
{
    using DevelopmentProjectErrorBoardUI.Models;

    public interface IErrorService
    {
        Task<List<ErrorAndPathModel>> GetAllErrorsAsync();
        Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(int errorId, int statusId);
    }
}