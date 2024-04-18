namespace DevelopmentProjectErrorBoardUI.Models
{
    public class DevCheckLogInModel
    {
        public UserModel? User { get; set; }
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}