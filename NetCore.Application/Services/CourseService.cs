using NetCore.Application.Interfaces;
using NetCore.Application.ViewModels;
using NetCore.Domain.Commands;
using NetCore.Domain.Core.Bus;
using NetCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus) {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel course)
        {
            var createCourseCommand = new CreateCourseCommand(
                    course.Name,
                    course.Description,
                    course.ImageUrl
                );

            _bus.SendCommand(createCourseCommand);
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
