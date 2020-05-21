using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class Course
    {
        //Δημιουργώ τα properties του course
        public string Title { get; set; }

        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; } = new DateTime();

        public DateTime EndDate { get; set; } = new DateTime();

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        


        //Δημιουργώ τον constructor του course
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά που θα υιοθετήσει η λίστα courses
        public void CourseOutput()
        {
            Console.WriteLine($"   Title:  {Title,-25}  |  Stream: {Stream,-37}   | Τype: {Type,-12} |");
        }
    }
}

