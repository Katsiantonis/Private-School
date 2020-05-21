using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class StudentPerAssignment
    {
        List<Student> Students = new List<Student>();

        Assignment Assignment;

        public StudentPerAssignment(Assignment assignment, List<Student> students)
        {
            Assignment = assignment;
            assignment.Students = students;

            foreach (var item in students)
            {
                item.Assignments.Add(assignment);
            }
        }
        public void StudentsperAssignmentOutput()
        {
            Console.WriteLine(Assignment.Title);
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in Assignment.Students)
            {
                Console.WriteLine($"  Name: {item.FirstName,-12} | Surname: {item.SurName,-26} |");

            }
            Console.WriteLine(" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }
    }
}
    
