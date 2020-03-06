//! You must define a type for representing a cohort in code.
//! The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.

namespace StudentExercises
{
    public class Cohort
    {
        //! Field
        //* Fields don't have a get; set; and are typically private
        // private int _milesDriven = 0;

        //! Properties
        //* Properties have a aget; set; and are typically public
        public string CohortName { get; set; }
        public string Students { get; set; }
        public string Instructors { get; set; }

        public string Description
        {
            get
            {
                return $"Cohort's {InstructorCohort} instructor is {FirstName } {LastName} @{SlackHandle}, they specialize in {InstructorSpecialty}";
            }
        }