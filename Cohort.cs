//! You must define a type for representing a cohort in code.
//! The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.

using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public Cohort(string cohortName, List<Student> students, List<Instructor> instructors)
        {
            CohortName = cohortName;
            Students = students;
            Instructors = instructors;
        }

    }
}