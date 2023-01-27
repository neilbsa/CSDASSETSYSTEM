using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSDASSETSYSTEM.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace CSDASSETSYSTEM.Models.Core
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }


      
        [Display(Name= "Email")]
        public string Username { get; set; }


        [Display(Name = "Password")]
        public string Password { get; set; }


        public  bool IsAdministrator { get; set; }
    }
}