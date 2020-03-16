using NetCore.Application.Interfaces;
using NetCore.Application.ViewModels;
using NetCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository) {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }

}
