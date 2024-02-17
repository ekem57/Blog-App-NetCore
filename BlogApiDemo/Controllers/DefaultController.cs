using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var values = c.Employees.Find(id);
            if(values == null)
            {
                return NotFound();
            }
            else { return Ok(values); }
            
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var values = c.Employees.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            { 
                c.Remove(values);
                c.SaveChanges ();
                return Ok(); 
            }

        }

        [HttpPut("{id}")]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var c = new Context();
            var values = c.Find<Employee>(employee.ID);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                values.Name = employee.Name;
                c.Update(values);
                c.SaveChanges();
                return Ok();
            }

        }



    }
}
