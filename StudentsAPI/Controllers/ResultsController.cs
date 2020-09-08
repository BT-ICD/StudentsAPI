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
    public class ResultsController : ControllerBase
    {
        private readonly ResultService _resultService;
        public ResultsController(ResultService resultService)
        {
            _resultService = resultService;
        }
        [HttpGet]
        public ActionResult<List<StudentResult>> list() =>
            _resultService.GetResults();
        [HttpGet("{enrollmentNo}")]
        public ActionResult<StudentResult> ByEnrollmentNo(string enrollmentNo)
        {
            var result = _resultService.GetResultByEnrollmentNo(enrollmentNo);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
                
    }
}