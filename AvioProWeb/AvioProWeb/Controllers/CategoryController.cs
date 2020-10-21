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
        public ActionResult SendEmail(string receiver, string subject, string body)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("smbudhwani@yahoo.com");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "Aug31999";
                    var sub = subject;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.yahoo.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
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
