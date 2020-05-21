using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class StudentPerCourse
    {
        List<Student> Students = new List<Student>();

        Course Course;


        public StudentPerCourse(Course course, List<Student> student)
        {
            Course = course;
            Students = student;
        }

        public void Output()
        {
            Console.WriteLine(Course.Title);
            Console.WriteLine("+--------------+--------------------+");
            foreach (var item in Students)
            {
                Console.WriteLine($"| {item.FirstName,-12} | {item.SurName,-18} |");

            }
            Console.WriteLine("+--------------+--------------------+");
        }
    }
}
