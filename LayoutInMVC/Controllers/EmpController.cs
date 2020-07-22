using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutInMVC.Controllers
{
    public class EmpController : Controller
    {
        [Route("AllEmp")]
        public ActionResult GetList() 
        {
            return View();
        }

        [Route("NewEmp")]
        public ActionResult AddEmp()
        {
            return View();
        }
    }
}