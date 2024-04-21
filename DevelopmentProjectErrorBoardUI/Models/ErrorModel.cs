namespace DevelopmentProjectErrorBoardUI.Models
{
    public class ErrorModel
    {
        public int ErrorId { get; set; }
        
        public string InitialFile { get; set; }
        
        public int LineNumber { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }
        
        public int AgentId { get; set; }
        
        public int? DeveloperId { get; set; }
        
        public int StatusId { get; set; }
        
        public string Message { get; set; }
        
        public bool IsActive { get; set; }
        
        public int ProjectId { get; set; }
        
        public int? CustomerId { get; set; }

    }
}