using DemoWebApp.Data;
using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public StudentController(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext= ApplicationDbContext;
        }


        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _ApplicationDbContext.Students;
        }




        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _ApplicationDbContext.Students.SingleOrDefault(x => x.Id == id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _ApplicationDbContext.Students.Add(student);
            _ApplicationDbContext.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Student student)
        {
            _ApplicationDbContext.Students.Update(student);
            _ApplicationDbContext.SaveChanges();

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _ApplicationDbContext.Students.SingleOrDefault(x => x.Id == id);
            if(item != null)
            {
                _ApplicationDbContext.Students.Remove(item);
                _ApplicationDbContext.SaveChanges();
            }
        }
    }
}
