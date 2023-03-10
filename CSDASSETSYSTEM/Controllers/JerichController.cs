using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSDASSETSYSTEM.Models.Core;
using CSDASSETSYSTEM.ViewModels;

namespace CSDASSETSYSTEM.Controllers
{
    public class JerichController : Controller
    {

        private readonly List<Department> dept = new List<Department>()
        {
            new Department(){Id=1, DepartmentCode= "CSD", DepartmentName = "COMPUTER"  },
            new Department(){Id=2, DepartmentCode= "HR", DepartmentName = "HUMAN RESOURCES" },
            new Department(){Id=3, DepartmentCode= "OTP", DepartmentName = "OFFICE OF THE PRESIDENT" },
            new Department(){Id=4, DepartmentCode= "FINANCE", DepartmentName = "FINANCIALS" },


        };


        private readonly List<Person> persons = new List<Person>() {
               new Person(){ Id=1,Department="CSD", CompanyID = "2282", Name = "Bryan" },
               new Person(){Id=2, Department="FINANCE", CompanyID = "22821", Name = "JErich" },
               new Person(){Id=3, Department="HR", CompanyID = "22822", Name = "Marieniel" },
               new Person(){Id=4, Department="HR", CompanyID = "22823", Name = "Risty" },
               new Person(){Id=5, Department="HR", CompanyID = "22823", Name = "Reymark" },
               new Person(){Id=6, Department="HR", CompanyID = "22823", Name = "Jayson" },
               new Person(){Id=7, Department="HR", CompanyID = "22823", Name = "Jessie" },
               new Person(){Id=8, Department="HR", CompanyID = "22823", Name = "Tommuel" },
               new Person(){Id=9, Department="HR", CompanyID = "22823", Name = "Henry" },
               new Person(){Id=10, Department="HR", CompanyID = "22823", Name = "Ian" },
               new Person(){Id=11, Department="HR", CompanyID = "22823", Name = "Jon" },
            };

     



        // GET: Jerich
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Redirect()
        {
            return View("Index");
        }

        public ActionResult PersonDetails()
        {
            Person per = new Person() { Id = 1, Name = "Marinel", CompanyID = "2525", Department = "CSD" };
            return View(per);
        }

        public ActionResult PersonDetailsViewBag()
        {

            ViewBag.Id = 1;
            ViewBag.Name = "Marinel";
            ViewBag.CompanyId = 2525;
            ViewBag.Department = "CSD";
            return View();
        }


        public ActionResult DepartmentDetailsViewBagandModel()
        {

            ViewBag.WelcomeMessage = "Hello! Good Day";
            List<Department> dept = new List<Department>() {
                new Department() { Id = 1, DepartmentCode = "CSD", DepartmentName = "Computer Systems Department"},
                new Department() { Id = 2, DepartmentCode = "MIC", DepartmentName = "Machines Inventory Control"},
                new Department() { Id = 3, DepartmentCode = "MKTG", DepartmentName = "Marketing"},
                new Department() { Id = 4, DepartmentCode = "FNC", DepartmentName = "Finance"},
                new Department() { Id = 5, DepartmentCode = "SCM", DepartmentName = "Supply Chain Management"},
                new Department() { Id = 6, DepartmentCode = "TS", DepartmentName = "Technical Support"},
                new Department() { Id = 7, DepartmentCode = "CT", DepartmentName = "Core Team"},
                new Department() { Id = 8, DepartmentCode = "TM", DepartmentName = "Telematics"},
                new Department() { Id = 9, DepartmentCode = "IC", DepartmentName = "Inventory Control"},
                new Department() { Id = 10, DepartmentCode = "WHS", DepartmentName = "Warehouse"},
                new Department() { Id = 11, DepartmentCode = "SVC", DepartmentName = "Service"}
            };
            return View(dept);
        }

        public ActionResult AssetDetailsViewBagandModelWithParameter(int? id, string name, string type, string model, DateTime? datepurchased, double? price, string serial, int? warranty)
        {

            ViewBag.FilterBy = "filter by: ?id=&name=&type=&model=&datepurchased=&price=&serial=&warranty=";
            List<Asset> asset = new List<Asset>() {
                new Asset() { Id = 1, AssetCode = "CSD-1", AssetName = "Lenovo", AssetType="Laptop", model="Apple MacBook Air (M2)", DatePurchased=DateTime.Parse("2023-01-01") , price= 2344, Serial="1410110058",Warranty=2},
                new Asset() { Id = 2, AssetCode = "CSD-2", AssetName = "Asus", AssetType="Desktop", model="HP Spectre x360 14", DatePurchased=DateTime.Parse("2022-10-01") , price= 2354654, Serial="1410110406",Warranty=6},
                new Asset() { Id = 3, AssetCode = "CSD-3", AssetName = "Acer", AssetType="Laptop", model="Asus ROG Zephyrus G15", DatePurchased=DateTime.Parse("2022-10-08") , price= 86785, Serial="1410110463",Warranty=3},
                new Asset() { Id = 4, AssetCode = "CSD-4", AssetName = "Dell", AssetType="Desktop", model="Asus Zenbook Pro Duo 14", DatePurchased=DateTime.Parse("2020-01-31") , price= 5645, Serial="1310110344",Warranty=7},
                new Asset() { Id = 5, AssetCode = "CSD-5", AssetName = "Apple", AssetType="Laptop", model="Asus Chromebook Flip CX5", DatePurchased=DateTime.Parse("2019-05-07") , price= 234235, Serial="1410110117",Warranty=3},
                new Asset() { Id = 6, AssetCode = "CSD-6", AssetName = "HP", AssetType="Desktop", model="HP Pavilion Aero 13", DatePurchased=DateTime.Parse("2016-05-27") , price= 231321, Serial="1310110111",Warranty=4},
                new Asset() { Id = 7, AssetCode = "CSD-7", AssetName = "Samsung", AssetType="Laptop", model="XPS 13", DatePurchased=DateTime.Parse("2022-02-24") , price= 223535, Serial="1410110074",Warranty=7},
                new Asset() { Id = 8, AssetCode = "CSD-8", AssetName = "MSI", AssetType="Desktop", model="Lenovo Yoga 7i", DatePurchased=DateTime.Parse("2019-07-27") , price= 1131322, Serial="1310110085",Warranty=6},
                new Asset() { Id = 9, AssetCode = "CSD-9", AssetName = "Razer", AssetType="Laptop", model="IdeaPad Duet", DatePurchased=DateTime.Parse("2023-01-08") , price= 122, Serial="1310110188",Warranty=5 },
                new Asset() { Id = 10, AssetCode = "CSD-10", AssetName = "Microsoft Surface", AssetType="Desktop", model="HP Envy 13", DatePurchased=DateTime.Parse("2021-09-08") , price= 1241, Serial="1310110002",Warranty=5},
                new Asset() { Id = 11, AssetCode = "CSD-11", AssetName = "Toshiba", AssetType="Laptop", model="Acer Swift 5", DatePurchased=DateTime.Parse("2022-01-10") , price= 411, Serial="1410110154",Warranty=2},
                new Asset() { Id = 12, AssetCode = "CSD-12", AssetName = "Compaq", AssetType="Desktop", model="MacBook Air (M1)", DatePurchased=DateTime.Parse("2022-01-02") , price= 5354, Serial="1310110148",Warranty=1},
            };

            ViewBag.ListofAssets = asset.Where(x =>
            (id == null || x.Id == id) &&
            (name == null || x.AssetName.Contains(name)) &&
            (type == null || x.AssetType.Contains(type)) &&
            (model == null || x.model.Contains(model)) &&
            (datepurchased == null || x.DatePurchased == datepurchased) &&
            (price == null || x.price == price) &&
            (serial == null || x.Serial.Contains(serial)) &&
             (warranty == null || x.Warranty == warranty)).ToList();



            return View();
        }

        public ActionResult ListofDepartment ()
        {

            return View(dept);
        }

        public ActionResult DepartmentDetailsWithMember(int Id)
        {
            var deptDetails = dept.Where(d => d.Id == Id ).SingleOrDefault();

            var personDetails = persons.Where(c => c.Department == deptDetails.DepartmentCode).ToList();

            var viewModel = new DepartmentDetailsAndMember
            {
                DepartmentDetails =deptDetails,
                PersonDetails = personDetails,
            };

            return View(viewModel);
        }


        public ActionResult PersonInDetails(int Id)
        {
            var per = persons.Where(c => c.Id ==Id).SingleOrDefault();  

            return View(per);
        }



        private readonly IEnumerable<User> user = new List<User>()
        {
            new User(){Id=1, Name= "CSD", Username = "admin" , Password="12345",IsAdministrator =true },
            new User(){Id=2, Name= "HR", Username = "HUMAN" , Password="54321",IsAdministrator =true},
            new User(){Id=3, Name= "OTP", Username = "OFFICE",  Password="harhar"},
            new User(){Id=4, Name= "FINANCE", Username = "FINANCIALS",  Password="haha"},


        };

        public ActionResult Login ()
        {

            return View();
        }




        [HttpPost]
        public ActionResult Login(User log)
        {
            var People = user.Where(x => x.Username.ToUpper() == log.Username.ToUpper() && x.Password == log.Password )
                .FirstOrDefault();


            if (People.IsAdministrator )

            {
                return RedirectToAction("AdminPage");
            }

            else
            {
                return RedirectToAction("UserPage"); 
            }
          
          


         

      
        }
        public ActionResult AdminPage()
        {

            return View();
        }
        public ActionResult UserPage()
        {

            return View();
        }

    }
}