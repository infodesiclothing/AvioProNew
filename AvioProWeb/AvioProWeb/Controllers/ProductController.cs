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
            //Turbine Oil
            if (Param == "AeroTurbineOilAscender")
            {
                return View("Aero_TurbineOil_Ascender");
            }
            if (Param == "AeroTurbineOil2EU")
            {
                return View("Aero_TurbineOil_2EU");
            }
            if (Param == "AeroTurbineOil2")
            {
                return View("Aero_TurbineOil_2");
            }
            if (Param == "AeroTurbineOil3")
            {
                return View("Aero_TurbineOil_3");
            }
            if (Param == "AeroTurbineOil308")
            {
                return View("Aero_TurbineOil_308");
            }
            if (Param == "AeroTurbineOil309")
            {
                return View("Aero_TurbineOil_309");
            }
            if (Param == "AeroTurbineOil500")
            {
                return View("Aero_TurbineOil_500");
            }
            if (Param == "AeroTurbineOil555")
            {
                return View("Aero_TurbineOil_555");
            }
            if (Param == "AeroTurbineOil560")
            {
                return View("Aero_TurbineOil_560");
            }
            if (Param == "AeroTurbineOil560")
            {
                return View("Aero_TurbineOil_560_b");
            }
            if (Param == "AeroTurbineOil750")
            {
                return View("Aero_TurbineOil_750");
            }
            //Added by Mohtashim for 3m-Tapes
            //3M Aerospace Tapes & Adhesives
            if (Param == "3m-polyurethane-protective-tape-8663") { return View("Tapes_protectivetape8663"); }
            if (Param == "3m-polyurethane-protective-tape-8681hs") { return View("Tapes_3mpolyurethaneprotectivetape8681hs"); }
            if (Param == "3m-polyurethane-protective-tape-8547") { return View("Tapes_3mpolyurethaneprotectivetape8547"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-1751-ba") { return View("Tapes_3mscotchweldepoxyadhesiveec1751ba"); }
            if (Param == "3m-scotch-weld-adhesivesealant-ec-3537-na-ba") { return View("Tapes_3mscotchweldadhesivesealantec3537naba"); }
            if (Param == "3m-scotch-weld-structural-adhesive-film-af-15") { return View("Tapes_3mscotchweldstructuraladhesivefilmaf15"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-3531-ba-fr") { return View("Tapes_3mscotchweldepoxyadhesiveec3531bafr"); }
            if (Param == "3m-polyurethane-protective-tape-8730na") { return View("Tapes_3mpolyurethaneprotectivetape8730na"); }
            if (Param == "3m-polyurethane-protective-tape-8673") { return View("Tapes_3mpolyurethaneprotectivetape8673"); }
            if (Param == "3m-polyurethane-protective-tape-8671") { return View("Tapes_3mpolyurethaneprotectivetape8671"); }
            if (Param == "3m-scotch-weld-bracket-bonding-adhesive-ec-7202") { return View("Tapes_3mscotchweldbracketbondingadhesiveec7202"); }
            if (Param == "3m-protective-tape-application-solution") { return View("Tapes_3mprotectivetapeapplicationsolution"); }
            if (Param == "3m-scotch-weld-urethane-adhesive-ec-3532-ba") { return View("Tapes_3mscotchweldurethaneadhesiveec3532ba"); }
            if (Param == "3m-scotch-weld-neoprene-high-performance-rubber-and-gasket-adhesive-ec-1300") { return View("Tapes_3msadhesiveec1300"); }
            if (Param == "3m-polyurethane-protective-tape-8544") { return View("Tapes_3mpolyurethaneprotectivetape8544"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-3537-na-ba") { return View("Tapes_3mscotchweldepoxyadhesiveec3537naba"); }
            if (Param == "3m-scotch-weld-urethane-adhesive-ec-3587-ba") { return View("Tapes_3mscotchweldurethaneadhesiveec3587ba"); }
            if (Param == "3m-scotch-weld-urethane-adhesive-ec-3535-ba") { return View("Tapes_3mscotchweldurethaneadhesiveec3535ba"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-2216-ba-gray") { return View("Tapes_3mscotchweldepoxyadhesiveec2216bagray"); }
            if (Param == "3m-scotch-weld-neoprene-high-performance-contact-adhesive-ec-1357") { return View("Tapes_3mscotchweldneoprenehighper1357"); }
            if (Param == "3m-polyurethane-protective-tape-8734na") { return View("Tapes_3mpolyurethaneprotectivetape8734na"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-2216-ba-translucent") { return View("Tapes_3mscotchweldepoxyadhesiveec2216batranslucent"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-2792-ba") { return View("Tapes_3mscotchweldepoxyadhesiveec2792ba"); }
            if (Param == "3m-scotch-weld-structural-adhesive-film-af-3185") { return View("Tapes_3mscotchweldstructuraladhesivefilmaf3185"); }
            if (Param == "3m-scotch-weld-repair-paste-rp-2220") { return View("Tapes_3mscotchweldrepairpasterp2220"); }
            if (Param == "3m-polyurethane-protective-tape-8663dl") { return View("Tapes_3mpolyurethaneprotectivetape8663dl"); }
            if (Param == "3M-Scotch-Weld-Structural-Adhesive-EC-1458") { return View("Tapes_3MScotchWeldStructuralAdhesiveEC1458"); }
            if (Param == "3m-scotch-weld-structural-adhesives-ec-3964") { return View("Tapes_3mscotchweldstructuraladhesivesec3964"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-1838") { return View("Tapes_3mscotchweldepoxyadhesiveec1838"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-1469") { return View("Tapes_3mscotchweldepoxyadhesiveec1469"); }
            if (Param == "3m-polyurethane-protective-tape-8657") { return View("Tapes_3mpolyurethaneprotectivetape8657"); }
            if (Param == "3m-polyurethane-protective-tape-8658dl") { return View("Tapes_3mpolyurethaneprotectivetape8658dl"); }
            if (Param == "3m-scotch-weld-structural-adhesive-7246-2-ba-fst") { return View("Tapes_3mscotchweldstructuraladhesive72462bafst"); }
            if (Param == "3m-scotch-weld-epoxy-adhesive-ec-3501-ba") { return View("Tapes_3mscotchweldepoxyadhesiveec3501ba"); }
            if (Param == "3m-scotch-weld-structural-adhesive-ec-3984") { return View("Tapes_3mscotchweldstructuraladhesiveec3984"); }
            if (Param == "3m-scotch-weld-structural-adhesive-ec-7236") { return View("Tapes_3mscotchweldstructuraladhesiveec7236"); }
            if (Param == "3m-polyurethane-protective-tape-8664hs") { return View("Tapes_3mpolyurethaneprotectivetape8664hs"); }
            if (Param == "3m-scotch-weld-structural-adhesive-film-af-555") { return View("Tapes_3mscotchweldstructuraladhesivefilmaf555"); }

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
