using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Validate;

namespace WebApplication2.Models
{
    public class InviteModel
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        [MyValidates]
        public string Email { get; set; }
        public bool? WillAttend { get; set; }

    }
}