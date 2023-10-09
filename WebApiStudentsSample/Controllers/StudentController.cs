using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStudentsSample.Models;

namespace WebApiStudentsSample.Controllers
{
    [Route("api/student")]
    public class StudentController : ApiController
    {
        IList<Students> Students = new List<Students>()
        {
            new Students()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar", Address = "New Delhi", Course = "IT"
                },
                new Students()
                {
                    StudentId = 2, StudentName = "Banky Chamber", Address = "London", Course = "HR"
                },
                new Students()
                {
                    StudentId = 3, StudentName = "Rahul Rathor", Address = "Laxmi Nagar", Course = "IT"
                },
                new Students()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh", Address = "Goa", Course = "Sales"
                },
                new Students()
                {
                    StudentId = 5, StudentName = "Manish Sharma", Address = "New Delhi", Course = "HR"
                },
        };
        [HttpGet]
        [Route("")]
        public IList<Students> GetAllStudents()
        {
            //Return list of all employees    
            return Students;
        }
        [HttpGet]
        [Route("studentdata")]
        public Students GetStudentDetails(int id)
        {
            //Return a single employee detail    
            var Student = Students.FirstOrDefault(e => e.StudentId == id);
            if (Student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Student;
        }
    }
}