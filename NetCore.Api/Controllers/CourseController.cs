

using Microsoft.AspNetCore.Mvc;
using NetCore.Application.Interfaces;
using NetCore.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace NetCore.Api.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService cs) {
            _courseService = cs;
        }
         
        public IActionResult Post([FromBody] CourseViewModel cwm){
            return Ok(cwm);
        }
    }
}
