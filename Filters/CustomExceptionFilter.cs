using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        private readonly IModelMetadataProvider _modelMetadataProvider;
        public CustomExceptionFilter(IModelMetadataProvider modelMetadataProvider)
        {
            _modelMetadataProvider = modelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            ErrorHandler.GetError(context.Exception);
            context.ExceptionHandled = true;


            if (context.HttpContext.Request.IsAjaxRequest())
            {
                context.Result = new StatusCodeResult(ErrorHandler.StatusCode);
            }
            else
            {
                ViewResult view = new ViewResult();
                view.ViewName = "Error";
                view.ViewData = new ViewDataDictionary(_modelMetadataProvider, context.ModelState);
                view.ViewData.Model = ErrorHandler.ErrorMessage;
                context.Result = view;
            }
        }
    }


    public class CustomValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.IsAjaxRequest())
                return;

            if (context.ModelState.IsValid)
                return;

            var ListError = (from state in context.ModelState.Values
                             from error in state.Errors
                             select error.ErrorMessage).ToList();

            string str = "خطا";
            foreach (var item in ListError)
            {
                str += "\n - " + item;
            }

            context.Result = new OkObjectResult(new { isNotValid=true,errorMessage=str });
        }
    }


}
