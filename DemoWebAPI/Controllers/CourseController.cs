using DemoWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [ApiController]
    [Route("/api/Course")]
    public class CourseController : Controller
    {
        private CourseService _courseService = null;

        public CourseController(CourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var courses = _courseService.GetCourses();
            return Ok(courses);
        }
    }
}
