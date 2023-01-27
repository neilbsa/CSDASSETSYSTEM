using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSDASSETSYSTEM.Models.Core;

namespace CSDASSETSYSTEM.ViewModels
{
    public class DepartmentDetailsAndMember
    {

        public Department DepartmentDetails { get; set; }   

        public List<Person> PersonDetails { get; set; }
    }
}