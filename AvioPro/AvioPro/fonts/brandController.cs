using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvioProWeb.Controllers    
{
    public class brandController : Controller
    {
        // GET: brand
        public ActionResult Index(string Params)
        {
            if (Params == "3m")
            {
                return View("ThreeM");
            }
            if (Params == "LPS")
            {
                return View("LPS");
            }
            if (Params == "AEROSHELL")
            {
                return View("AEROSHELL");
            }
            if (Params == "AIRCRAFTTYRES")
            {
                return View("AIRCRAFTTYRES");
            }
            if (Params == "NITTOTAPES")
            {
                return View("NITTOTAPES");
            }

            


            return View("ThreeM");
        }
    }
}
