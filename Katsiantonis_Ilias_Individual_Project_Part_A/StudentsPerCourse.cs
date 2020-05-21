using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class StudentsPerCourse
    {

        List<Student> Students = new List<Student>();

        Course Course;



        public StudentsPerCourse(Course course, List<Student> students)
        {
            Course = course;
            course.Students = students;
            foreach (var item in students)
            {
                item.Courses.Add(course);
            }
        }



        public void StudentsperCourseOutput()
        {
            Console.WriteLine(Course.Title);
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Course.Students)
            {
                Console.WriteLine($"  Name: {item.FirstName,-12} | Surname: {item.SurName,-26} |");

            }
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }
    }
}
