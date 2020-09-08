using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Model;
using StudentsAPI.Services;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public ActionResult<List<Student>> list() =>
                _studentService.GetStudents();
        [HttpGet("{id:length(24)}")]
        public ActionResult<Student> GetById(string id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
                return NotFound();
            return student;
        }

    }
}