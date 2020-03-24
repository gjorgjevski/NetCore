using System;
using System.Collections.Generic;
using NetCore.Domain.Models;
using System.Text;

namespace NetCore.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
