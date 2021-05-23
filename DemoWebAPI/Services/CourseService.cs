using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Services
{
    public class CourseService
    {
        public List<Course> course_list;

        public CourseService()
        {
            course_list = new List<Course>
            {
                new Course{ CourseId = 1, CourseName = "AZ-204"},
                new Course{ CourseId = 2, CourseName = "AZ-304"},
                new Course{ CourseId = 3, CourseName = "AZ-404"}
            };
        }
    
        public IEnumerable<Course> GetCourses(){
            return course_list;
        }
    
    }
}
