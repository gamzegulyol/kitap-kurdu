﻿using Bitirme.Eticaret.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Eticaret.UI.WEB.Controllers
{
    public class BasketController : BitirmeControllerBase
    {
        // GET: Basket
        [HttpPost]
        public JsonResult AddProduct(int productID, int quantity)
        {

            var db = new BitirmeDB();
            db.Baskets.Add(new Core.Model.Entity.Basket
            {
                CreateDate = DateTime.Now,
                CreateUserID = LoginUserID,
                ProductID = productID,
                Quantity = quantity,
                UserID = LoginUserID 
 
            });
           var rt= db.SaveChanges();
            return Json(rt, JsonRequestBehavior.AllowGet);
        }

        [Route("Sepetim")]

        public ActionResult Index()
        {

            var db = new BitirmeDB();

            var data = db.Baskets.Include("Product").Where(x => x.UserID == LoginUserID);

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var db = new BitirmeDB();

            var deleteitem = db.Baskets.Where(x => x.ID == id).FirstOrDefault();
            db.Baskets.Remove(deleteitem);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}