using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_A
{
    class Lists
    {
        public List<Student> students { get; set; } = new List<Student>();

        public List<Trainer> trainers { get; set; } = new List<Trainer>();

        public List<Assignment> assignments { get; set; } = new List<Assignment>();   
        
        public List<Course> courses { get; set; } = new List<Course>();

        public List<StudentsPerCourse> studentsPerCourse { get; set; } = new List<StudentsPerCourse>();

        public List<TrainersPerCourse> trainersPerCourse { get; set; } = new List<TrainersPerCourse>();

        public List<AssignmentsPerCourse> assignmentsPerCourse { get; set; } = new List<AssignmentsPerCourse>();

        public List<StudentPerAssignment> studentsPerAssignment { get; set; } = new List<StudentPerAssignment>();       
        

        public Lists()
        {
            // Lists Creation
            Student student_1 = new Student("Bruce", "Wayne       (Batman)", new DateTime(1978, 01, 27), 8450);
            Student student_2 = new Student("Peter", "Parker      (Spiderman)", new DateTime(1978, 02, 26), 8450);
            Student student_3 = new Student("Tony", "Stark       (Iron Man)", new DateTime(1979, 03, 25), 8820);
            Student student_4 = new Student("Barry", "Allen       (Flash)", new DateTime(1979, 04, 24), 8930);
            Student student_5 = new Student("Bruce", "Banner      (Hulk)", new DateTime(1980, 05, 23), 8680);
            Student student_6 = new Student("Arthur", "Curry       (Aquaman)", new DateTime(1980, 06, 22), 8768);
            Student student_7 = new Student("Remy ", "LeBeau      (Gambit)", new DateTime(1981, 07, 21), 8935);
            Student student_8 = new Student("Dru", "Zod         (General Zod)", new DateTime(1981, 08, 20), 8720);
            Student student_9 = new Student("Raven", "Darkholme   (Mystique)", new DateTime(1982, 09, 19), 8690);
            Student student_10 = new Student("Adrian", "Veidt       (Ozymandias)", new DateTime(1982, 10, 18), 8000);
            Student student_11 = new Student("Magnus", "Eisenhardt  (Magneto)", new DateTime(1983, 11, 17), 8650);
            Student student_12 = new Student("Kal", "El          (Superman)", new DateTime(1983, 12, 16), 8450);
            Student student_13 = new Student("Obadiah", "Stane       (Iron Monger)", new DateTime(1984, 01, 15), 8820);
            Student student_14 = new Student("Charles", "Xavier      (Professor X)", new DateTime(1984, 02, 14), 8930);
            Student student_15 = new Student("Oswald", "Cobblepot   (The Penguin)", new DateTime(1985, 03, 13), 8680);
            Student student_16 = new Student("Benjamin", "Grimm       (The Thing)", new DateTime(1985, 04, 12), 8768);
            Student student_17 = new Student("Wade", "Wilson      (Deadpool)", new DateTime(1986, 05, 11), 8935);
            Student student_18 = new Student("Ororo", "Monroe      (Storm)", new DateTime(1986, 06, 10), 8720);
            Student student_19 = new Student("Armando", "Munoz       (Darwin)", new DateTime(1987, 07, 14), 8690);
            Student student_20 = new Student("Victor", "Von Doom    (Dr Doom)", new DateTime(1987, 08, 16), 8000);

            Trainer trainer_1 = new Trainer("Barbara", "Gordon     (Oracle)", "Academic Associate");
            Trainer trainer_2 = new Trainer("Walter", "Langkowski (Sasquatch)", "Academic Associate");
            Trainer trainer_3 = new Trainer("Victor ", "Creed      (Sabertooth)", "Academic Associate");
            Trainer trainer_4 = new Trainer("Thor ", "Odinson    (Thor)", "Academic Associate");
            Trainer trainer_5 = new Trainer("John", "Irons      (Steel)", "Academic Associate");
            Trainer trainer_6 = new Trainer("Jonathan", "Osterman   (Dr. Manhattan)", "Academic Associate");
            Trainer trainer_7 = new Trainer("Walter", "Kovacs     (Rorschach)", "Academic Assistant");
            Trainer trainer_8 = new Trainer("Loki", "Laufeyson  (Loki)", "Academic Assistant");

            Assignment assignment_1 = new Assignment("Assignment A'", "Basic Fundamentals", new DateTime(2020, 3, 24), 10, 100);
            Assignment assignment_2 = new Assignment("Assignment B'", "Hardware Systems", new DateTime(2020, 4, 10), 10, 100);
            Assignment assignment_3 = new Assignment("Assignment C'", "Windows.NET software", new DateTime(2020, 4, 24), 10, 100);
            Assignment assignment_4 = new Assignment("Assignment D'", "Software Development ", new DateTime(2020, 5, 22), 10, 100);
            Assignment assignment_5 = new Assignment("Assignment E'", "Front-End Environment", new DateTime(2020, 6, 24), 10, 100);
            Assignment assignment_6 = new Assignment("Individual Project", "Backend Environment", new DateTime(2020, 7, 12), 20, 100);
            Assignment assignment_7 = new Assignment("Team Project", "Website Development", new DateTime(2020, 8, 19), 30, 100);                   

            Course course_1 = new Course("C# Sharp ", "ASP .NET MVC", "Full Time", new DateTime(2020, 2, 24), new DateTime(2020, 9, 1));
            Course course_2 = new Course("C# Sharp ", "SQL Server", "Full Time", new DateTime(2020, 2, 24), new DateTime(2020, 9, 1));
            Course course_3 = new Course("Java ", "Maven / Tomcat", "Part Time", new DateTime(2020, 2, 24), new DateTime(2020, 9, 1));
            Course course_4 = new Course("JavaScript ", "Express JS", "Part Time", new DateTime(2020, 2, 24), new DateTime(2020, 9, 1));
          
            // Add objects to my lists :

            students.Add(student_1);
            students.Add(student_2);
            students.Add(student_3);
            students.Add(student_4);
            students.Add(student_5);
            students.Add(student_6);
            students.Add(student_7);
            students.Add(student_8);
            students.Add(student_9);
            students.Add(student_10);
            students.Add(student_11);
            students.Add(student_12);
            students.Add(student_13);
            students.Add(student_14);
            students.Add(student_15);
            students.Add(student_16);
            students.Add(student_17);
            students.Add(student_18);
            students.Add(student_19);
            students.Add(student_20);

            //.............................//

            trainers.Add(trainer_1);
            trainers.Add(trainer_2);
            trainers.Add(trainer_3);
            trainers.Add(trainer_4);
            trainers.Add(trainer_5);
            trainers.Add(trainer_6);
            trainers.Add(trainer_7);
            trainers.Add(trainer_8);

            //..............................//          

            assignments.Add(assignment_1);
            assignments.Add(assignment_2);
            assignments.Add(assignment_3);
            assignments.Add(assignment_4);
            assignments.Add(assignment_5);
            assignments.Add(assignment_6);
            assignments.Add(assignment_7);

            //.............................//

            courses.Add(course_1);
            courses.Add(course_2);
            courses.Add(course_3);
            courses.Add(course_4);




            // Δημιουργώ τις λίστες για τους students per course 
            List<Student> list_of_students_per_course1 = new List<Student>() { student_1, student_2, student_3, student_4, student_5, student_9 };         
            StudentsPerCourse students_per_course1 = new StudentsPerCourse(course_1, list_of_students_per_course1);
           
            List<Student> list_of_students_per_course2 = new List<Student>() { student_6, student_7, student_8, student_9, student_10, student_11 };
            StudentsPerCourse students_per_course2 = new StudentsPerCourse(course_2, list_of_students_per_course2);
           
            List<Student> list_of_students_per_course3 = new List<Student>() { student_11, student_12, student_13, student_14, student_15, student_17 };
            StudentsPerCourse students_per_course3 = new StudentsPerCourse(course_3, list_of_students_per_course3);           

            List<Student> list_of_students_per_course4 = new List<Student>() { student_16, student_17, student_18, student_19, student_20 };
            StudentsPerCourse students_per_course4 = new StudentsPerCourse(course_4, list_of_students_per_course4);

         


            // Δημιουργώ τις λίστες για τους Trainers per course 
            List<Trainer> list_of_trainers_per_course1 = new List<Trainer>() { trainer_1, trainer_2 };
            TrainersPerCourse trainers_per_course1 = new TrainersPerCourse(course_1, list_of_trainers_per_course1);          

            List<Trainer> list_of_trainers_per_course2 = new List<Trainer>() { trainer_3, trainer_4 };
            TrainersPerCourse trainers_per_course2 = new TrainersPerCourse(course_2, list_of_trainers_per_course2);           

            List<Trainer> list_of_trainers_per_course3 = new List<Trainer>() { trainer_5, trainer_6 };
            TrainersPerCourse trainers_per_course3 = new TrainersPerCourse(course_3, list_of_trainers_per_course3);

            List<Trainer> list_of_trainers_per_course4 = new List<Trainer>() { trainer_7, trainer_8 };
            TrainersPerCourse trainers_per_course4 = new TrainersPerCourse(course_4, list_of_trainers_per_course4);

           


            // Δημιουργώ τις λίστες για τις assignments per course
            List<Assignment> list_of_assignments_per_course1 = new List<Assignment>() { assignment_1, assignment_2, assignment_3, assignment_4 };
            AssignmentsPerCourse assignments_per_course1 = new AssignmentsPerCourse(course_1, list_of_assignments_per_course1);
          
            List<Assignment> list_of_assignments_per_course2 = new List<Assignment>() { assignment_1, assignment_2, assignment_3, assignment_4 };
            AssignmentsPerCourse assignments_per_course2 = new AssignmentsPerCourse(course_2, list_of_assignments_per_course2);          

            List<Assignment> list_of_assignments_per_course3 = new List<Assignment>() { assignment_1, assignment_2, assignment_3, assignment_4 };
            AssignmentsPerCourse assignments_per_course3 = new AssignmentsPerCourse(course_3, list_of_assignments_per_course3);
            
            List<Assignment> list_of_assignments_per_course4 = new List<Assignment>() { assignment_1, assignment_2, assignment_3, assignment_4 };
            AssignmentsPerCourse assignments_per_course4 = new AssignmentsPerCourse(course_4, list_of_assignments_per_course4);

           


            // Δημιουργώ τις λίστες για τους students per assignment
            List<Student> list_of_students_per_assignment1 = new List<Student>() { student_1, student_2, student_3, student_4, student_5 };
            StudentPerAssignment students_per_assignment1 = new StudentPerAssignment(assignment_1, list_of_students_per_assignment1);
          
            List<Student> list_of_students_per_assignment2 = new List<Student>() { student_6, student_7, student_8, student_9, student_10 };
            StudentPerAssignment students_per_assignment2 = new StudentPerAssignment(assignment_2, list_of_students_per_assignment2);

            List<Student> list_of_students_per_assignment3 = new List<Student>() { student_11, student_12, student_13, student_14, student_15 };
            StudentPerAssignment students_per_assignment3 = new StudentPerAssignment(assignment_3, list_of_students_per_assignment3);
          
            List<Student> list_of_students_per_assignment4 = new List<Student>() { student_16, student_17, student_18, student_19, student_20 };
            StudentPerAssignment students_per_assignment4 = new StudentPerAssignment(assignment_4, list_of_students_per_assignment4);
       
            List<Student> list_of_students_per_assignment5 = new List<Student>() { student_16, student_17, student_18, student_19, student_20 };
            StudentPerAssignment students_per_assignment5 = new StudentPerAssignment(assignment_5, list_of_students_per_assignment5);         

            List<Student> list_of_students_per_assignment6 = new List<Student>() { student_16, student_17, student_18, student_19, student_20 };
            StudentPerAssignment students_per_assignment6 = new StudentPerAssignment(assignment_6, list_of_students_per_assignment6);
           
            List<Student> list_of_students_per_assignment7 = new List<Student>() { student_16, student_17, student_18, student_19, student_20 };
            StudentPerAssignment students_per_assignment7 = new StudentPerAssignment(assignment_7, list_of_students_per_assignment7);



            studentsPerCourse.Add(students_per_course1);
            studentsPerCourse.Add(students_per_course2);
            studentsPerCourse.Add(students_per_course3);
            studentsPerCourse.Add(students_per_course4);


            trainersPerCourse.Add(trainers_per_course1);
            trainersPerCourse.Add(trainers_per_course2);
            trainersPerCourse.Add(trainers_per_course3);
            trainersPerCourse.Add(trainers_per_course4);


            assignmentsPerCourse.Add(assignments_per_course1);
            assignmentsPerCourse.Add(assignments_per_course2);
            assignmentsPerCourse.Add(assignments_per_course3);
            assignmentsPerCourse.Add(assignments_per_course4);


            studentsPerAssignment.Add(students_per_assignment1);
            studentsPerAssignment.Add(students_per_assignment2);
            studentsPerAssignment.Add(students_per_assignment3);
            studentsPerAssignment.Add(students_per_assignment4);
            studentsPerAssignment.Add(students_per_assignment5);
            studentsPerAssignment.Add(students_per_assignment6);
            studentsPerAssignment.Add(students_per_assignment7);



            //=========================================================================================================================================//
           //      SYNTHETIC DATA     ================================================================================================================//

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t   WELCOME TO OUR AMAZING PRIVATE SCHOOL ");
            Console.WriteLine("  \t\t\t\t\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    
            Console.WriteLine(" \t\t\t\t\t\t\t\t  <<<      S.U.P.E.R.H.E.R.O.E.S      >>>\n\n\n\n\n");           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Type the letter ..(Y)..or..(N) if you want to input your personal Data or not.\n\n");
            


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Enter your choice (Y/N):  ");           
            string userChoice = Console.ReadLine().ToUpper();

            while ((userChoice != "Y") && (userChoice != "N"))
            {
                Console.Write("\a Invalid Input..Try again with (Y) or (N):  ");
                userChoice = Console.ReadLine();
            }





            if (userChoice == "Y")
            {


                string studentChoice = "";
                do
                {
                    Console.WriteLine("\n\n\n  --------------------");
                    Console.WriteLine("  <<<STUDENT DATA>>>");
                    Console.WriteLine("  --------------------\n");



                    Console.Write("  Enter First Name:  ");
                    string FirstName = Console.ReadLine();
                    Console.Write("  Enter Surname:  ");
                    string SurName = Console.ReadLine();
                    Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                                  "  Enter your Date of Birth:  ");
                    DateTime DateofBirth = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("  Enter Tuition Fees:  ");
                    int TuitionFees = Convert.ToInt32(Console.ReadLine());


                   
                    Student student = new Student(FirstName, SurName, DateofBirth, TuitionFees);
                    students.Add(student);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n  Press (Y) or (N) if you want to add another student: ");
                    studentChoice = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                } while (studentChoice.ToUpper() == "Y");





                string trainerChoice = "";
                do
                {
                    Console.WriteLine("\n\n\n  --------------------");
                    Console.WriteLine("  <<<TRAINER DATA>>>");
                    Console.WriteLine("  --------------------\n");



                    Console.Write("  Enter trainer's name:  ");
                    string FirstName = Console.ReadLine();
                    Console.Write("  Enter trainer's Surname:  ");
                    string SurName = Console.ReadLine();
                    Console.Write("  Enter trainer's Subject:  ");
                    string Subject = Console.ReadLine();



                    Trainer trainer = new Trainer(FirstName, SurName, Subject);
                    trainers.Add(trainer);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n  Press (Y) or (N) if you want to add another trainer: ");
                    trainerChoice = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                } while (trainerChoice.ToUpper() == "Y");





                string assignmentChoice = "";
                do
                {
                    Console.WriteLine("\n\n\n  --------------------");
                    Console.WriteLine("  <<<ASSIGNMENT DATA>>>");
                    Console.WriteLine("  --------------------\n");



                    Console.Write("  Enter Assigment Title:  ");
                    string Title = Console.ReadLine();
                    Console.Write("  Enter Assigment description:  ");
                    string Description = Console.ReadLine();
                    Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                                  "  Enter Assignment Date:  ");
                    DateTime SubDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("  Enter an Oral Mark Points from 0 to 100:  ");
                    int OralMark = Convert.ToInt32(Console.ReadLine());
                    Console.Write("  Enter the Total Mark Points:  ");
                    int TotalMark = Convert.ToInt32(Console.ReadLine());



                    Assignment assignment = new Assignment(Title, Description, SubDate, OralMark, TotalMark);
                    assignments.Add(assignment);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n  Press (Y) or (N) if you want to add another assignment: ");
                    assignmentChoice = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;

                } while (assignmentChoice.ToUpper() == "Y");
                




                string courseChoice = "";
                do
                {
                    Console.WriteLine("\n\n\n  --------------------");
                    Console.WriteLine("  <<<COURSE DATA>>>");
                    Console.WriteLine("  --------------------\n");



                    Console.Write("  Enter Course Title (etc C# Sharp,Java or JavaScript):  ");
                    string Title = Console.ReadLine();
                    Console.Write("  Enter Course Stream:  ");
                    string Stream = Console.ReadLine();
                    Console.Write("  Enter Course type (etc Full Time or Part Time):  ");
                    string Type = Console.ReadLine();
                    Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                                  "  Enter Start Date of the Course:  ");
                    DateTime StartDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("  Enter End Date of the Course:  ");
                    DateTime EndDate = Convert.ToDateTime(Console.ReadLine());



                    Course course = new Course(Title, Stream, Type, StartDate, EndDate);
                    courses.Add(course);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n  Press (Y) or (N) if you want to add another course: ");
                    courseChoice = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\n\n");
                } while (courseChoice.ToUpper() == "Y");
            
                                         
                }
            else if (userChoice == "N")


            {
                Console.WriteLine("\n\n\n\n\n\n  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~   PERSONAL INFORMATION FOR STUDENTS-TRAINERS-ASSIGNMENTS & COURSES   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~   ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            }
        }





        // Students list
        public void TotalofStudents()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t<<< STUDENTS >>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in students)
            {
                item.StudentOutput();
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
        }





        // Trainers List
        public void TotalofTrainers()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t<<< TRAINERS >>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in trainers)
            {
                item.TrainerOutput();
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
        }





        // Assignments List
        public void TotalofAssignments()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t<<< ASSIGNMENTS >>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in assignments)
            {
                item.AssignmentOutput();
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n");
        }





        // Courses List
        public void TotalofCourses()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t<<< COURSES >>>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in courses)
            {
                item.CourseOutput();
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\n");
        }





        // Students per course List
        public void TotalStudentsPerCourse()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t<<< STUDENTS PER COURSE >>>\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in studentsPerCourse)
            {
                item.StudentsperCourseOutput();
            }
            Console.WriteLine("\n\n");
        }





        // Trainers per Course List
        public void TotalTrainersPerCourse()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t<<< TRAINERS PER COURSE >>>\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in trainersPerCourse)
            {
                item.TrainerOutput();
            }
            Console.WriteLine("\n\n");
        }





        // Assignments per Course List
        public void TotalAssignmentsPerCourse()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t<<< ASSIGNMENTS PER COURSE >>>\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in assignmentsPerCourse)
            {
                item.AssignmentsperCourseOutput();
            }
            Console.WriteLine("\n\n");
        }





        // Students per Assignment List
        public void TotalStudentsPerAssignment()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t<<< STUDENTS PER ASSIGNMENT >>>\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in studentsPerAssignment)
            {

                item.StudentsperAssignmentOutput();
            }
            Console.WriteLine("\n\n");
        }
        



        // Students με πολλαπλά courses
        public void multiCourseStudents()
        {
            List<Student> multiCourseStudents = new List<Student>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t<<< STUDENTS WITH MULTIBLE COURSES >>> \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in students)
            {
                if (item.Courses.Count() > 1)
                {
                    multiCourseStudents.Add(item);
                    Console.WriteLine($"  Name: {item.FirstName,-12} | Surname: {item.SurName,-25} |");
                }
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }




        // Students με πολλαπλά assignments
        public void multiAssignmentStudents()
        {
            List<Student> multiAssignmentStudents = new List<Student>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t<<< STUDENTS WHO OWE MORE THAN ONE ASSIGNMENTS >>> \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var item in students)
            {
                if (item.Assignments.Count() > 1)
                {
                    multiAssignmentStudents.Add(item);
                    Console.WriteLine($"  Name: {item.FirstName,-12} | Surname: {item.SurName,-25} |");
                }
            }
            Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t\tTHANK YOU FOR YOUR TIME !! ");
           
            Console.ReadKey();
        }
    }
}
 