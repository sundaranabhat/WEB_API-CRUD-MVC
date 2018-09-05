using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MVC.Controllers
{
    public class TestController : Controller
    {

        // GET: Test/Index
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> EmployeeList;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Test").Result;
            //Converting the response to Ienumerable of mvcEmployeeModel
            EmployeeList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;
            return View(EmployeeList);

        }

        public ActionResult Details(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Test/" + id).Result;
            var getResult = response.Content.ReadAsAsync<mvcEmployeeModel>().Result;
            return View(getResult);

        }
        //Http:Get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(mvcEmployeeModel emp)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Test", emp).Result;
            TempData["SuccessMessage"] = "New Profile Created Successfully";
            return RedirectToAction("Index");
        }

        //Get
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Test/" + id).Result;
            var result = response.Content.ReadAsAsync<mvcEmployeeModel>().Result;
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(mvcEmployeeModel model)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Test/" + model.EmployeeID, model).Result;
            TempData["SuccessMessage"] = "Profile Updated Successfully";
            return RedirectToAction("Index");
        }


        //POST

        public ActionResult Delete(int id)

        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Test/" + id).Result;
            TempData["SuccessMessage"] = "Profile Deleted Successfully";

            return RedirectToAction("Index");
        }

    }
}

