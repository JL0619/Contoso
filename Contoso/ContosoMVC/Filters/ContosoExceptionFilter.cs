using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
     
namespace ContosoMVC.Filters
{
    public class ContosoExceptionFilter : HandleErrorAttribute 
    {
        private static Logger logger;
        public ContosoExceptionFilter()
        {
            logger = LogManager.GetCurrentClassLogger();

        }
        public override void OnException(ExceptionContext filterContext)
        {
            var controllerName = (string)filterContext.RouteData.Values["controller"];
            var actionName = (string)filterContext.RouteData.Values["action"];
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
            filterContext.Result = new ViewResult
            {
                ViewName = View,
                MasterName = Master,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                TempData = filterContext.Controller.TempData
            };
            string exceptionPath = filterContext.HttpContext.Request.Path + filterContext.HttpContext.Request.QueryString;
            //log exception information like
            //1.exception
            //2.Inner message of exception ->filter
            //3.datetime => datetime.now
            //4.action method name and contoller name
            //5.the whole state trace
            //6.Exception path(URL)->filterContext.exception
            //7.LOG ablove details using Nlog to text file

            logger.Log(LogLevel.Info, filterContext.Exception);
            logger.Log(LogLevel.Info, filterContext.Exception.Message);
            logger.Log(LogLevel.Info, filterContext.Exception.InnerException);
            logger.Log(LogLevel.Info, filterContext.Exception.StackTrace);
            logger.Log(LogLevel.Info, DateTime.Now);
            logger.Log(LogLevel.Info, controllerName);
            logger.Log(LogLevel.Info, actionName);
            logger.Log(LogLevel.Info, exceptionPath);

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;


            base.OnException(filterContext);
        }
    }
}