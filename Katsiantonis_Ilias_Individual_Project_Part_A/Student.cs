using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class Student
    {
        //Δημιουργώ τα properties του student
        public string FirstName { get; set; }

        public string SurName { get; set; }       
        
        public DateTime DateOfBirth { get; set; } = new DateTime();

        public int TuitionFees { get; set; }

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public List<Course> Courses { get; set; } = new List<Course>();




        //Δημιουργώ τον constructor του student
        public Student(string firstName, string surName, DateTime dateOfBirth, int tuitionFees)
        {
            FirstName = firstName;
            SurName = surName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
          
            

        }       
        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά που θα υιοθετήσει η λίστα student
        public void StudentOutput()
        {
            Console.WriteLine($"   Name:   {FirstName,-25}  |  Surname:    {SurName,-35} |  Date of Birth:    {DateOfBirth,-30}  | Tuition Fees:    {TuitionFees,-1} $ |");           
        }
    }
}
   
