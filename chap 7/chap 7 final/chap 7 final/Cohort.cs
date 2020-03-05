using System;
using System.Collections.Generic;
using System.Text;

namespace chap_7_final
{
    class Cohort
    {
        public Cohort(string cohortName)
        {
            Name = cohortName;
            Students = new List<Student>();
            Instructors = new List<Instructor>();
        }
        public string Name { get; set; }
        private List<Student> Students { get; set; }
        public void AddStudent(Student newStudent)
        {
            newStudent.Cohort = this;
            Students.Add(newStudent);
        }
        private List<Instructor> Instructors { get; set; }
        public void AddInstructor(Instructor instructor)
        {
            instructor.InstructorCohort = this;
            Instructors.Add(instructor);
        }



    }

}

