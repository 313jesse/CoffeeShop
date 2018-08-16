using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class UserInfo
    {
        [Required]   //THis is called an "Attribute" adding this here will make the field required. 
        [RegularExpression("^[a-zA-Z]{3,30}$")]
        public string FirstName { set; get; }
        [Required]
        [RegularExpression("^[a-zA-Z]{2,25}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{4}$")]
        public string Phone { set; get; }
           

        public UserInfo()
        {
            FirstName = ""; 
            LastName = "";
            Phone = "";
        }

        public UserInfo(string fn, string ln, string ph)
            {
                FirstName = fn;
                LastName = ln;
            Phone = ph;
            }
        }
    }
