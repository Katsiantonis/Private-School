using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class AssignmentsPerCourse
    {
        
        Course Course;
       
        

        public AssignmentsPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;
            course.Assignments = assignments;

            foreach (var item in assignments)
            {
                item.Courses = course;
            }
        }



        public void AssignmentsperCourseOutput()
        {
            Console.WriteLine(Course.Title);
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in Course.Assignments)
            {
                Console.WriteLine($"  Title: {item.Title,-15} | Description: {item.Description,-23}| Submission Date: {item.SubDateTime.ToString("dd/MM/yyyy"),-10} |");
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }
    }
}
