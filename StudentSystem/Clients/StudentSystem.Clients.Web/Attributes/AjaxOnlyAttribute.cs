﻿namespace StudentSystem.Clients.Web.Attributes
{
    using System;

    using System.Web.Mvc;

    [AttributeUsage(AttributeTargets.Method)]
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                filterContext.HttpContext.Response.StatusCode = 404;
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}