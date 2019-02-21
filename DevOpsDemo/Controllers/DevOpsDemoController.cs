using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevOpsDemo.Controllers
{
    public class DevOpsDemoController : Controller
    {
        // GET: DevOpsDemo
        public ActionResult Index()
        {
			int x = 1;
            return View();
        }
    }
}