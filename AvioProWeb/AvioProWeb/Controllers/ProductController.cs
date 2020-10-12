using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace AvioProWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string Param)
        {
            if (Param == "3MScotch1252")
            {
                return View("coating_3MScotch1252");
            }
            if (Param == "3MScotch776")
            {
                return View("coating_3MScotch776");
            }
            if (Param == "3MScotch5816")
            {
                return View("coating_3MScotch5816");
            }
            if (Param == "3MScotch1137")
            {
                return View("coating_3MScotch1137");
            }
            if (Param == "3MScotch776SR")
            {
                return View("coating_3MScotch776SR");
            }
            //Adhersion Promoters & Primers
            if (Param == "3MPromoters5000")
            {
                return View("Promoters_3MPromoters5000");
            }
            if (Param == "3MPromoters5000AS")
            {
                return View("Promoters_3MPromoters5000AS");
            }
            if (Param == "3MPromoters131")
            {
                return View("Promoters_3MPromoters131");
            }
            if (Param == "3MPromoters86A")
            {
                return View("Promoters_3MPromoters86A");
            }
            if (Param == "3MPromoters132")
            {
                return View("Promoters_3MPromoters132");
            }
            if (Param == "3MPromoters130")
            {
                return View("Promoters_3MPromoters130");
            }
            if (Param == "3MPromoters1945")
            {
                return View("Promoters_3MPromoters1945");
            }
            if (Param == "3MPromoters137")
            {
                return View("Promoters_3MPromoters137");
            }
            if (Param == "3MPromoters160")
            {
                return View("Promoters_3MPromoters160");
            }
            if (Param == "3MPromoters5005")
            {
                return View("Promoters_3MPromoters5005");
            }
            if (Param == "3MPromoters3960")
            {
                return View("Promoters_3MPromoters3960");
            }
            if (Param == "3MPromoters2333")
            {
                return View("Promoters_3MPromoters2333");
            }
            if (Param == "3MPromoters2174")
            {
                return View("Promoters_3MPromoters2174");
            }
            if (Param == "3MPromoters3924")
            {
                return View("Promoters_3MPromoters3924");
            }
            if (Param == "3MPromoters3901")
            {
                return View("Promoters_3MPromoters3901");
            }
            if (Param == "3MPromoters1593")
            {
                return View("Promoters_3MPromoters1593");
            }
            if (Param == "3MPromoters1660")
            {
                return View("Promoters_3MPromoters1660");
            }
            if (Param == "3MPromoters3917")
            {
                return View("Promoters_3MPromoters3917");
            }
            if (Param == "3MPromoters1290")
            {
                return View("Promoters_3MPromoters1290");
            }
            //Fluids
            if (Param == "AeroShellFluid2")
            {
                return View("Aero_Fluid2");
            }
            if (Param == "AeroShellCompound7")
            {
                return View("Aero_Compound7");
            }
            if (Param == "AeroShellFluid2XN")
            {
                return View("Aero_Fluid2XN");
            }
            if (Param == "AeroShellFluid3")
            {
                return View("Aero_Fluid3");
            }
            if (Param == "AeroShellFluid5MA")
            {
                return View("Aero_Fluid5MA");
            }
            if (Param == "AeroShellFluid12")
            {
                return View("Aero_Fluid12");
            }
            if (Param == "AeroShellFluid31")
            {
                return View("Aero_Fluid31");
            }
            if (Param == "AeroShellFluid61")
            {
                return View("Aero_Fluid61");
            }
            if (Param == "AeroShellFluid41")
            {
                return View("Aero_Fluid41");
            }
            if (Param == "AeroShellFluid602")
            {
                return View("Aero_Fluid602");
            }
            if (Param == "AeroShellFluid8350")
            {
                return View("Aero_Fluid8350");
            }
            if (Param == "AeroShellGearFluid")
            {
                return View("Aero_GearFluid");
            }
            if (Param == "AeroShelSmokeOil")
            {
                return View("Aero_SmokeOil");
            }
            //Lubricants
            if (Param == "LPSChainMate")
            {
                return View("LPS_ChainMate");
            }
            if (Param == "LPSPTFE")
            {
                return View("LPS_PTFE");
            }
            if (Param == "LPSGreaseLess")
            {
                return View("LPS_GreaseLess");
            }
            if (Param == "LPSHeavyDuty")
            {
                return View("LPS_HeavyDuty");
            }
            if (Param == "LPSPenetrant")
            {
                return View("LPS_Penetrant");
            }
            //Corrosion
            if (Param == "Corrosion")
            {
                return View("LPS_Corrosion");
            }
            //AeroShell Grease
            if (Param == "AeroOil100")
            {
                return View("Aero_Oil100");
            }
            if (Param == "AeroOilDUltra")
            {
                return View("Aero_OilDUltra");
            }
            if (Param == "AeroOilSPlus4")
            {
                return View("Aero_OilSPlus4");
            }
            if (Param == "AeroOilW100")
            {
                return View("Aero_OilW100");
            }
            if (Param == "AeroOilW")
            {
                return View("Aero_OilW");
            }
            if (Param == "AeroOilW80")
            {
                return View("Aero_OilW80");
            }
            if (Param == "AeroOil100Pl")
            {
                return View("Aero_Oil100Pl");
            }
            if (Param == "AeroOilW120")
            {
                return View("Aero_OilW120");
            }
            //Electronic Cleaners
            if (Param == "LPSCFCCleaners")
            {
                return View("LPS_CFCCleaners");
            }
            if (Param == "LPS140Cleaners")
            {
                return View("LPS_140Cleaners");
            }
            if (Param == "LPSElectroCleaners")
            {
                return View("LPS_ElectroCleaners");
            }
            if (Param == "LPS2NoFlashCleaners")
            {
                return View("LPS_2NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            //AeroShell Piston Oil
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }
            if (Param == "LPSNoFlashCleaners")
            {
                return View("LPS_NoFlashCleaners");
            }

            return View("coating_3mscotch");
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
