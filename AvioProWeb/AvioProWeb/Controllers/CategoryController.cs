using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using AvioProWeb.Models;

namespace AvioProWeb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string Params)
        { 
            if(Params == "Coatings")
            {
            return View("COATINGS");
            }
            if (Params == "promoters")
            {
                return View("AdhesionPromoters");
            }
            if (Params == "Fluids")
            {
                return View("AEROSHELL_Fluids");
            }
            if (Params == "Lubricants")
            {
                return View("Lubricants");
            }
            if (Params == "Corrosion")
            {
                return View("CorrosionInhibitors");
            }
            if (Params == "GREASE")
            {
                return View("AeroShell_Grease");
            }
            if (Params == "Cleaners")
            {
                return View("Electronic_Cleaners");
            }
            if (Params == "Tapes")
            {
                return View("AerospaceTapes");
            }
            if (Params == "PistonOIL")
            {
                return View("PistonOil");
            }
            if (Params == "TURBINE OIL")
            {
                return View("TurbineOil");
            }
            
            return View("COATINGS");
        }
        public ActionResult DeleteCart(Cart cart)
        {
            List<Cart> li = (List<Cart>)Session["cart"];
            li.RemoveAll(x => x.PartNumber == cart.PartNumber && x.Brand==cart.Brand && x.Name==cart.Name && x.Units==cart.Units);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return View("MyCart", (List<Cart>)Session["cart"]);
        }
        public ActionResult AddCart(string PartNumber, string Brand, string Name, string Units)
        {
            Cart cart = new Cart
            {

                PartNumber = PartNumber,
                Brand = Brand,
                Name = Name,
                Units = Units,
               
            };
            if (Session["cart"] == null)
            {
               
                List<Cart> li = new List<Cart>();
                li.Add(cart);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = 1;
                return View("MyCart", (List<Cart>)Session["cart"]);
            }
            else
            {
                List<Cart> li = (List<Cart>)Session["cart"];
                li.Add(cart);//newly entered item
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                return View("MyCart", (List<Cart>)Session["cart"]);

            }
            
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SendEmail(string Name, string Email, string Phoneno, string Subject, string bodytxt)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("Info@avio-pro.com");
                message.To.Add("Info@avio-pro.com");
                message.Bcc.Add("mohtashim.siddiqui74@outlook.com");
                message.Bcc.Add("smbudhwani@yahoo.com");
                message.Subject = Subject;
                message.Body = bodytxt;
                message.IsBodyHtml = true;

                var client = new SmtpClient("smtp.outlook.com", 587)
                {
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential("mohtashim.siddiqui74@outlook.com", "mohtashim098"),
                    EnableSsl = true
                };
                client.Send(message);

                //return View("~/Index/Home");
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Error = "Some Error";
            }
            //return View("~/Index/Home");
            return RedirectToAction("Index");
        }
        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
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

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
