namespace DevelopmentProjectErrorBoardUI.Services
{
    using DevelopmentProjectErrorBoardUI.Models;

    public interface IErrorService
    {
        Task<List<ErrorAndPathModel>> GetAllErrorsAsync();
        Task<List<ErrorAndPathModel>> UpdateErrorStatusAsync(UpdateErrorStatusModel model/*int errorId, int statusId, int agentId*/);
    }
}