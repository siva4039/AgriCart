using System;

namespace API.Errors
{
    public class ApiResponse
    {
       
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return StatusCode switch
            {
                400 => "A bad request, you have given",
                401 => "Authorized, you are not",
                404 => "Resource Not Found",
                500 => "Error from internal server",
                _=> null
            };  
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}