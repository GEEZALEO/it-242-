using System;

namespace chap_7_final
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Exercise Exercise1 = new Exercise()
            {
                Name = "Run",
                Language = "C#"
            };

            Exercise Exercise2 = new Exercise()
            {
                Name = "Jump",
                Language = "C#"
            };
            Exercise Exercise3 = new Exercise()
            {
                Name = "Skip",
                Language = "C#"
            };
            Exercise Exercise4 = new Exercise()
            {
                Name = "Climb",
                Language = "C#"
            };


            Cohort Cohort1 = new Cohort("Cohort 1");

            Student GN = new Student()
            {
                FirstName = "George",
                LastName = "Newman"
            };
                  Cohort Cohort2 = new Cohort("Cohort 2");

            Student AM = new Student()
            {
                FirstName = "Antonio",
                LastName = "Martinez"
            };
                  Cohort Cohort3 = new Cohort("Cohort 3");

            Student KN = new Student()
            {
                FirstName = "Kayla",
                LastName = "Newman"

            };


            Instructor RM = new Instructor()
            { 
               
            };

            Instructor MC = new Instructor()
            {

            };

            Instructor CB = new Instructor()
            {

            };
            Cohort1.AddInstructor(RM);



            RM.AssignExercise(GN, Exercise1);


            Cohort1.AddStudent(GN);

            









        }
    }
}
