﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Controller]
    public class ApiController
    {
        [ActionContext]
        public ActionContext ActionContext { get; set; }

        public HttpContext HttpContext => ActionContext?.HttpContext;

        public HttpRequest Request => ActionContext?.HttpContext?.Request;

        public HttpResponse Response => ActionContext?.HttpContext?.Response;

        public IServiceProvider Resolver => ActionContext?.HttpContext?.RequestServices;
    }
}
