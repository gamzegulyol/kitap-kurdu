﻿using Bitirme.Eticaret.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitirme.Eticaret.UI.WEB.Controllers
{
    public class ProductController : BitirmeControllerBase
    {
        // GET: Product
        [Route("Urun/{title}/{id}")]
        public ActionResult Detail(string title,int id)
        {
            var db = new BitirmeDB();
            var prod = db.Products.Where(x => x.ID == id).FirstOrDefault();
            return View(prod);
        }
    }
}