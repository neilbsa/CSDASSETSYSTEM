using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CSDASSETSYSTEM.Models.Core
{

    //ONE TO ONE
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string CompanyID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string BriefIntroduction { get; set; }
        public int DepartmentId { get; set; }
        //one to many
        [ForeignKey("DepartmentId")]
        public virtual Department DepartmentDetails { get; set; }
        


        
        //one to one
        public virtual Address AddressDetails { get; set; }
    }


    public class Address
    {

        [ForeignKey("Person")]
        public int Id { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Brgy { get; set; }
        public string ZipCode { get; set; }
        public virtual Person Person { get; set; }

    }



}