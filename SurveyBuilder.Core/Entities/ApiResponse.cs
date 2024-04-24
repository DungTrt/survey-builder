using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Entities
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object? Resources { get; set; }
        public object? Errors { get; set; }
        public bool IsSucceeded { get; set; }

        public static ApiResponse Success(string? message = "Success")
        {
            return new ApiResponse()
            {
                Status = 200,
                Message = message,
                IsSucceeded = true,
            };
        }
        public static ApiResponse Success<T>(T? data, string? message = "Success") where T : class
        {
            return new ApiResponse()
            {
                Status = 200,
                Message = message,
                IsSucceeded = true,
                Resources = data
            };
        }


        public static ApiResponse Success<T>(PagingData<T>? data) where T : class
        {
            return new ApiResponse()
            {
                Status = 200,
                Message = "Success",
                Resources = data,
                IsSucceeded = true
            };
        }

        public static ApiResponse Created<T>(T data)
        {
            return new ApiResponse()
            {
                Status = 201,
                Message = "Created",
                IsSucceeded = true,
                Resources = data
            };
        }

        public static ApiResponse Error(int status, object errors, string? message = null)
        {
            return new ApiResponse()
            {
                Status = status,
                Message = message,
                Errors = errors,
                IsSucceeded = false
            };
        }

        public static ApiResponse Error(string? message = "Error")
        {
            return new ApiResponse()
            {
                Status = 400,
                Message = message,
                IsSucceeded = false
            };
        }

        public static ApiResponse NotFound(object errors)
        {
            return Error(404, errors, "Not found");
        }

        public static ApiResponse BadRequest(object errors)
        {
            return Error(400, errors, "Bad request");
        }


        public static ApiResponse Unauthorized(object errors)
        {
            return Error(401, errors, "Unauthorized");
        }

        public static ApiResponse Forbidden(object errors)
        {
            return Error(403, errors, "Forbidden");
        }
    }
}
