using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio181.Controllers
{
    public class AccessController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string pass)
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("Ocurrrio un error:("+ ex.Message);
            }
        }
    }
}