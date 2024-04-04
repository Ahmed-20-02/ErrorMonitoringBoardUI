using DevelopmentProjectErrorBoardUI.Models;

namespace DevelopmentProjectErrorBoardUI.Services;

public interface IErrorService
{
    Task<IEnumerable<ErrorAndPathModel>> GetAsync(string endpoint);
}