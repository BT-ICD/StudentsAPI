﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Model;
using StudentsAPI.Services;


/// <summary>
/// Learning Reference: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1&tabs=visual-studio
/// </summary>
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