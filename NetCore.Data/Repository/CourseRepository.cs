using NetCore.Data.Context;
using NetCore.Domain.Interfaces;
using NetCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx) {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
