namespace DevelopmentProjectErrorBoardUI.Models
{
    public class ErrorAndPathModel
    {
        public ErrorModel Error { get; set; }
        public List<ErrorLogPathModel> LogPaths { get; set; }
    }
}