using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class TestController : ApiController
    {
        private CRUDDBEntities db = new CRUDDBEntities();

        // GET: api/Test

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        // GET: api/Test/5

        public HttpResponseMessage Get(int id)
        {
            var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);
            if(result != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id"+" " + id.ToString() +" " + "not Found" );

            }

        }

       
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            //Get Uri of the new item created employee

            var message = Request.CreateResponse(HttpStatusCode.Created, employee);
            message.Headers.Location = new Uri(Request.RequestUri + employee.EmployeeID.ToString());
            return message;
        }

       

        public HttpResponseMessage Put(int id, [FromBody] Employee employee)
        {
            try
            {
                var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);
                if (result != null)
                {
                    result.EmployeeID = employee.EmployeeID;
                    result.Name = employee.Name;
                    result.Age = employee.Age;
                    result.Position = employee.Position;
                    result.Salary = employee.Salary;
                    db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.OK, id.ToString() + " has been updated successfully");
                    return message;
                }

                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, id.ToString() + " not found to update");
                }
            }

            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            

        }

       
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);

                if (result == null)
                {
                    var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, id.ToString() + " does not exist");
                    return message;
                }

                else
                {
                    db.Employees.Remove(result);
                    db.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.OK, id.ToString() + " has been deleted");
                    return message;
                }
            }

            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
           
            
            
        }
    }
}
