using NetCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Application.Interfaces
{
    interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
