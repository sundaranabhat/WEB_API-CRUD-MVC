using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    //We recreated the same Model as in WEBAPI project.
    //it is safer to create the same model than to use the reference
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }
        [Required (ErrorMessage ="This Field is Required")]
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}