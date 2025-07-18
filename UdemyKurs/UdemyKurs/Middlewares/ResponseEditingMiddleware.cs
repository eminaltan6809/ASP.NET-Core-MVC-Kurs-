﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyKurs.Middlewares
{
    public class ResponseEditingMiddleware
    {
        private RequestDelegate _requestDelegate;

        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
            if(context.Response.StatusCode == StatusCodes.Status404NotFound)
                await context.Response.WriteAsync("Bu sayfa bulunamadı.");
        }
    }
}
