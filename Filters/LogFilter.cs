
using DataLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public class LogFilterAttribute : Attribute, IActionFilter
    {
        private readonly IKhabarContext _Context = null;
        private readonly IHostingEnvironment _env = null;
        public LogFilterAttribute(IKhabarContext Context, IHostingEnvironment env)
        {
            this._Context = Context;
            this._env = env;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_env.IsDevelopment())
            {
                return;
            }
            Domains.Log log = new Domains.Log()
            {
                ActionName = context.ActionDescriptor.DisplayName,

            };
            this._Context.Logs.Add(log);
            this._Context.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            throw new NotImplementedException();
        }



        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }
    }
}
