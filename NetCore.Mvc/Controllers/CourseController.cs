using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCore.Application.Interfaces;
using NetCore.Application.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService course_service) {
            _courseService = course_service;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }
    }
}
