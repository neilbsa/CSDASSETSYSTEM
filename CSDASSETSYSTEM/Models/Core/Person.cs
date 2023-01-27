using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSDASSETSYSTEM.Models.Core
{
    public class Person
    {
        public int Id { get; set; }
        public string CompanyID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BriefIntroduction { get; set; }

    


    }
}