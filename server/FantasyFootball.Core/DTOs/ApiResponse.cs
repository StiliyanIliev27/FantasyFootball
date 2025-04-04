namespace FantasyFootball.Core.DTOs
{
    public class ApiResponse
    {
        public object? Result { get; set; }
        public int StatusCode { get; set; }
        public string? SuccessfulMessage { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
