using System;
using System.Collections.Generic;
using System.Text;

namespace chap_7_final
{  
    class Student
    {
        public Student()
        { Exercises = new List<Exercise>();
        }


        public string FirstName { get; set; }



        public string LastName { get; set; }



        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
 
        public List<Exercise> Exercises { get; set; }

           
    }
}

