using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSDASSETSYSTEM.Models.Core
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        public virtual  List<Person> DepartmentMembers { get; set; }
    }
}