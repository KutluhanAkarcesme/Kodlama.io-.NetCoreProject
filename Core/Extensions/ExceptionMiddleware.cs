using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            string message = $"Bir hata oluştu = {exception.Message}";

            if (exception.GetType() == typeof(ValidationException))
            {
                message = exception.Message;
            }
            else if (exception.GetType() == typeof(DbUpdateException))
            {
                message = exception.InnerException.Message;
            }
            else if (exception.GetType() == typeof(DbUpdateConcurrencyException))
            {

            }
            else if (exception.GetType() == typeof(DuplicateNameException))
            {

            }
            else if (exception.GetType() == typeof(NotSupportedException))
            {

            }
            else if (exception.GetType() == typeof(ObjectDisposedException))
            {

            }
            else if (exception.GetType() == typeof(InvalidOperationException))
            {
                if (exception.Message.Contains("Unable to resolve service for type"))
                    message = $"Dependency Injection Reference Hatası = {exception.Message}";
                else if (exception.Message.StartsWith("Cannot create a DbSet for") &&
                         exception.Message.EndsWith("because this type is not included in the model for the context."))
                    message = "Yeni eklemiş olduğun tablo class bilgisini DataAccess>Concrete>Context içine eklemememişsin.";
                else
                    message = exception.Message;
            }

            return httpContext.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = message
            }.ToString());
        }
    }
}
