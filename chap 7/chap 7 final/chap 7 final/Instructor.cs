using System;
using System.Collections.Generic;
using System.Text;

namespace chap_7_final
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Instructor(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
​
        //}
​
        public string InstructorSlackHandle { get; set; }
​
        public Cohort InstructorCohort { get; set; }
        public string Specialty { get; set; }
​
​
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);

        }
    }
