using CSDASSETSYSTEM.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSDASSETSYSTEM.Controllers
{
    public class AssetController : Controller
    {
        // GET: Asset
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View("Index");
        }

        public ActionResult AssetDetails()
        {
            // Asset asset = new Asset() { Id = 1, AssetCode="CSD-0001",AssetName="LAptop", AssetType= "LPT" };
            Asset asset = new Asset();
            return View("Asset", asset);
        }


        public ActionResult AssetDetailsWithViewBag()
        {
            // Asset asset = new Asset() { Id = 1, AssetCode="CSD-0001",AssetName="LAptop", AssetType= "LPT" };
            ViewData["Name"] = "Bryan";
            ViewBag.FullAddress = "NOVALICHES QUEZON CITY";
            return View();
        }


        public ActionResult AssetDetailsWithViewBagAndModel()
        {
            // Asset asset = new Asset() { Id = 1, AssetCode="CSD-0001",AssetName="LAptop", AssetType= "LPT" };
            Asset asset = new Asset();
            ViewBag.Date = "1/6/2023";




            return View("Asset", asset);


        }









    }
}