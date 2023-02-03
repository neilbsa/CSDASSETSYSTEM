using CSDASSETSYSTEM.Data.context;
using CSDASSETSYSTEM.Models.Core;
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


        //PROJECT 2

        private readonly List<Department> dept = new List<Department>()
        {
            new Department(){ DepartmentCode= "CSD", DepartmentName = "COMPUTER" },
            new Department(){ DepartmentCode= "HR", DepartmentName = "HUMAN RESOURCES" },
            new Department(){ DepartmentCode= "OTP", DepartmentName = "OFFICE OF THE PRESIDENT" },
            new Department(){ DepartmentCode= "FINANCE", DepartmentName = "FINANCIALS" },


        };


        private readonly List<Person> persons = new List<Person>() {
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





        public ActionResult RegistrationForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationForm(string Name, string LastName)
        {
             ViewBag.FullName = String.Format("{0},{1}", Name, LastName);
            return View();
        }




        public ActionResult RegistrationFormWithModel()
        {



            //       new SelectList(RetrieveBranches(), "Id", "Name", entity.BranchId)


            string[] genders = new string[] { "Male", "Female" };
            ViewBag.GenderOptions = new SelectList(genders);
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationFormWithModel(Person entity)
        {
            ViewBag.FullName = String.Format("{0}", entity.Name);



            if (entity.IsAdmin)
            {
                return RedirectToAction("AdminPage");
            }
            else
            {
                return RedirectToAction("UserPAge");
            }
           
        }




   


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
           
            ViewBag.ListOfPerson = persons.Where(
                per =>
                (Id == null || per.Id == Id) 
                &&
                (Name == null || per.Name.ToUpper().Contains(Name.ToUpper()))

                ).ToList();
            return View();
        }




 
        public ActionResult UserDetails(int Id)
        {
            var person = persons.Where(x => x.Id == Id).FirstOrDefault();
            return View(person);
        }










        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Person entity)
        {

            using (AppDbContext context = new AppDbContext())
            {
                context.Persons.Add(entity);

                context.SaveChanges();
            }
                return View();
        }



        public ActionResult Details(int Id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var personDetail = context.Persons.Find(Id);

                return View(personDetail);
            }
        }




        [HttpGet]
        public ActionResult Update(int Id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var personDetail = context.Persons.Find(Id);

                return View(personDetail);
            }
        }



        [HttpPost]
        public ActionResult Update(Person entity)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var forupdateEntity = context.Persons.Find(entity.Id);



                forupdateEntity.Gender = entity.Gender;
                forupdateEntity.AddressDetails = entity.AddressDetails;
                //lahat ng gusto mong i update andito dpaat bago mag save changes
                context.SaveChanges();


                return RedirectToAction("Details", new { Id = forupdateEntity.Id });
            }
        }






        public ActionResult Delete(int Id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var personDetail = context.Persons.Find(Id);
                ViewBag.Message = "Are you sure you want to delete";
                return View(personDetail);
            }
        }


        [HttpPost]
        public ActionResult DeleteConfirmed(int Id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var personDetail = context.Persons.Find(Id);
                

                if(personDetail != null)
                {
                    context.Persons.Remove(personDetail);
                    context.SaveChanges();
                    return View(personDetail);
                }
                else
                {
                    return RedirectToAction("Index");
                }
               
            }
        }




    }
}