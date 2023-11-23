using PartialViewsdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewsdemo.Controllers
{

    [Log]
    public class CustomerController : Controller
    {
        // GET: Customer
        [Authorize]
        public ActionResult Index()
        {

            ViewBag.msg = "For authorised users only";

            return View();

        }
        
        public ActionResult FindCustomer()
        {
            //ActionExecutingContext actionExecuting = new ActionExecutingContext();
            //object id1=0;
            //object id=1;

            //bool ans = actionExecuting.FActionParameters["id1"].Equals("id");
            //if (id1.Equals(1)) {
            //    ViewBag.value=id1;

            //}
                
                    return View();
        }

        [HandleError]
        [HandleError(ExceptionType =typeof(DivideByZeroException),View ="Error1")]
        public ActionResult ShowCustomer() {

            //int[] arr = new int[5] { 1, 3, 45, 67, 7 };
            //ViewBag.result = arr[7];

            int i = 4, j = 0, ans = 0;
            ans = i / j;
            ViewBag.result = ans;
            //try
            //{
            //    ans = i / j;
            //    ViewBag.result = ans;
            //}
            //catch (Exception ex)
            //{

            //    return View("Error");
            //}
            //finally { }
            return View();  

        }


        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    //base.OnException(filterContext);
        //    string action = filterContext.RouteData.Values["action"].ToString();
        //    Exception e=filterContext.Exception;
        //    filterContext.ExceptionHandled = true;
        //    filterContext.Result = new ViewResult() {ViewName="Error" };
        //}
    }
}