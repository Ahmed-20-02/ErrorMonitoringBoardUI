using DevelopmentProjectErrorBoardUI.Models;

namespace DevelopmentProjectErrorBoardUI.Services;

public interface IErrorService
{
    Task<List<ErrorAndPathModel>> GetAllErrorsAsync();
}