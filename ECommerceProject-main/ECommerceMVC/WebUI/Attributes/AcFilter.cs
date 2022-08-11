using Model.Context;
using Model.DesignPattern;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Attributes
{
    public class AcFilter : FilterAttribute, IActionFilter
    {
        AppDbContext db = Singleton.Context;
        AppUser user = new AppUser();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log log = new Log();
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            if (filterContext.HttpContext.Session["user"] != null)
            {
                user = filterContext.HttpContext.Session["user"] as AppUser;
            }
            else
            {
                log.UserName = "cookie";
                
            }
            log.UserName = user.UserName;
            db.Logs.Add(log);
            db.SaveChanges();

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
    }
}