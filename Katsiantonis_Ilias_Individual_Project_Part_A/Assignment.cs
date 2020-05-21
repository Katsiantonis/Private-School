using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class Assignment
    {
        //Δημιουργώ τα properties του assignment
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; } = new DateTime(); 

        public int OralMark { get; set; }

        public int TotalMark { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public Course Courses { get; set; }
       


        //Δημιουργώ τον constructor του assignment
        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά που θα υιοθετήσει η λίστα assignments
        public void AssignmentOutput()
        { 
        Console.WriteLine($"   Title:  {Title,-25}  |  Description: {Description,-34} | Submission Date: {SubDateTime,-32}  | Oral Mark: {OralMark,-8} % | Total Mark: {TotalMark,-8} % |");
        }
    }
}
   
