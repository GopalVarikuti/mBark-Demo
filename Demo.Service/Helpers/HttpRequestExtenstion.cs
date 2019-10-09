using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Demo.Service.Helpers
{
    public static class HttpRequestExtenstion
    {
        public static IActionResult CreateResponse(this HttpRequest request, HttpStatusCode statusCode, string reasonPhrase = null)
        {
            var result = new ObjectResult(reasonPhrase ?? string.Empty)
            {
                StatusCode = (int)statusCode
            };
            return result;
        }

        public static IActionResult CreateResponse(this HttpRequest request, HttpStatusCode statusCode, object result)
        {
            if (result != null)
            {
                var response = new ObjectResult(result)
                {
                    StatusCode = (int)statusCode
                };
                return response;
            }

            return new StatusCodeResult((int)statusCode);
        }

        public static IActionResult CreateErrorResponse(this HttpRequest request, HttpStatusCode statusCode, string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var response = new ObjectResult(message)
                {
                    StatusCode = (int)statusCode
                };
                return response;
            }

            return new StatusCodeResult((int)statusCode);
        }
    }
}
