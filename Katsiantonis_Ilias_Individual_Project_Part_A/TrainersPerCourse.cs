using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class TrainersPerCourse
    {

        List<Trainer> Trainers = new List<Trainer>();

        Course Course;



        public TrainersPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;
            course.Trainers = trainers;
            foreach (var item in trainers)
            {
                item.Courses = course;
            }
        }



        public void TrainerOutput()
        {
            Console.WriteLine(Course.Title);
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in Course.Trainers)
            {
                Console.WriteLine($"  Name: {item.FirstName,-12} | Surnname: {item.SurName,-26} | Subject: {item.Subject,-12} |");
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }
    }
}
    