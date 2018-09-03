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

        public Employee Get(int id)
        {
            var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);

            return result;
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        [HttpPut]

        public void Put(int id, [FromBody] Employee employee)
        {
            var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);
            if(result != null)
            {

                result.EmployeeID = employee.EmployeeID;
                result.Name = employee.Name;
                result.Age = employee.Age;
                result.Position = employee.Position;
                result.Salary = employee.Salary;
                db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            else
            {
                NotFound();
            }

        }

        [HttpDelete]
        public void Delete(int id)
        {
            var result = db.Employees.FirstOrDefault(p => p.EmployeeID == id);
            db.Employees.Remove(result);
            db.SaveChanges();
            
        }
    }
}
