using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class Trainer
    {
        //Δημιουργώ τα properties του trainer
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Subject { get; set; }

        public Course Courses { get; set; }


        //Δημιουργώ τον constructor του trainer
        public Trainer(string firstName, string surName, string subject)
        {
            FirstName = firstName;
            SurName = surName;
            Subject = subject;           
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά που θα υιοθετήσει η λίστα trainer
        public void TrainerOutput()
        {          
            Console.WriteLine($"   Name:   {FirstName,-25}  |  Surname:    {SurName,-35} |  Subject:   {Subject,-37}  |");           
        }
    }
}
