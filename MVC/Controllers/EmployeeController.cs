using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Net.Http;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> empList;

            //in the GetAsync method we passed the remaining part of the URI 
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees").Result;
            //Converting the response to Ienumerable of mvcEmployeeModel
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;
            return View(empList);
        }
    }
}