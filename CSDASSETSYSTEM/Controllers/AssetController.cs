﻿using CSDASSETSYSTEM.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Asset asset = new Asset() { Id = 1, AssetCode = "CSD-0001", AssetName = "LAptop", AssetType = "LPT" };

            List<Person> persons = new List<Person>() {
               new Person(){ Department="CSD", CompanyID = "2282", Name = "Bryan" },
               new Person(){ Department="FINANCE", CompanyID = "22821", Name = "Bryan1" },
                new Person(){ Department="OTP", CompanyID = "22822", Name = "Bryan2" },
                new Person(){ Department="HR", CompanyID = "22823", Name = "Bryan3" },
            };


            ViewBag.Date = "1/6/20d23";
            ViewBag.ListOfPerson = persons;
            return View("Asset", asset);
        }


        public ActionResult AssetDetailsWithViewBagAndModelWithParameter(int? Id, string Name)
        {
            List<Person> persons = new List<Person>() {
               new Person(){ Id=1,Department="CSD", CompanyID = "2282", Name = "Bryan" },
               new Person(){Id=2, Department="FINANCE", CompanyID = "22821", Name = "JErich" },
                new Person(){Id=3, Department="OTP", CompanyID = "22822", Name = "Marieniel" },
                new Person(){Id=4, Department="HR", CompanyID = "22823", Name = "Risty" },
                 new Person(){Id=5, Department="HR", CompanyID = "22823", Name = "Reymark" },
                  new Person(){Id=6, Department="HR", CompanyID = "22823", Name = "Jayson" },
                   new Person(){Id=7, Department="HR", CompanyID = "22823", Name = "Jessie" },
                    new Person(){Id=8, Department="HR", CompanyID = "22823", Name = "Tommuel" },
                    new Person(){Id=9, Department="HR", CompanyID = "22823", Name = "Henry" },
                    new Person(){Id=10, Department="HR", CompanyID = "22823", Name = "Ian" },
                    new Person(){Id=11, Department="HR", CompanyID = "22823", Name = "Jon" },
            };
            ViewBag.ListOfPerson = persons.Where(
                per => 
                (Id == null || per.Id == Id) &&
                (Name == null || per.Name.ToUpper().Contains(Name.ToUpper()))
                
                ).ToList();
            return View();
        }






    }
}