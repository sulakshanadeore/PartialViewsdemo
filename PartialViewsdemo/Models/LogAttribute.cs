using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PartialViewsdemo.Models
{
    public class LogAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

           
            Log("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            filterContext.ActionParameters.Add("id1", 1);
            Debug.WriteLine(filterContext.ActionParameters["id1"]);
            Log("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);

            Log("OnResultExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //    base.OnResultExecuting(filterContext);
            Log("OnResultExecuting", filterContext.RouteData);
        }
        private  void Log(string methodname,RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var msg=string.Format("{0}---controller: {1} action :{2}",methodname, controllerName, actionName);
            Debug.WriteLine(msg);
            
        }
        

    }
}