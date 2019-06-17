using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bitirme.Eticaret.UI.WEB.Areas.Admin.Controllers
{
    public class AdminControllerBase: Controller
    {

        protected override void Initialize(RequestContext requestContext)
        {
            var IsLogin = false;
            if(requestContext.HttpContext.Session["AdminLoginUser"]==null)
            {
                //Admin girisi yapilamadi

                requestContext.HttpContext.Response.Redirect("Admin / AdminLogin");
            }
            else
            {
                //admin giriş yaptı, sayfayı çalıştır
            }
            base.Initialize(requestContext);
        }
    }
}