using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Shared.Exceptions
{
    internal sealed class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (TravelerCheckListExceptions ex)
            {
                await HandleTravelerCheckListExceptionAsync(context, ex);
            }
            catch (Exception ex) 
            {
                await HandleGenericExceptionAsync(context, ex);
            }
        }

        private Task HandleTravelerCheckListExceptionAsync(HttpContext context, TravelerCheckListExceptions ex)
        {
            context.Response.StatusCode = 400; 
            context.Response.ContentType = "application/json";

            var errorCode = ToUnderscoreCase(ex.GetType().Name.Replace("Exception", string.Empty));
            var json = JsonSerializer.Serialize(new { ErrorCode = errorCode, ex.Message });
            return context.Response.WriteAsync(json);
        }

        private Task HandleGenericExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = 500; 
            context.Response.ContentType = "application/json";

            var json = JsonSerializer.Serialize(new { ErrorCode = "internal_server_error", Message = "An unexpected error occurred." });
            return context.Response.WriteAsync(json);
        }

        private string ToUnderscoreCase(string input)
        {
            return Regex.Replace(input, "(?<!^)([A-Z])", "_$1").ToLower();
        }
    }

}

