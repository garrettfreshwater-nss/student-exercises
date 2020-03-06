//! You must define a type for representing an exercise in code. An exercise can be assigned to many students.
//! Name of exercise
//! Language of exercise (JavaScript, Python, CSharp, etc.)

namespace StudentExercises
{
    public class Exercise
    {
        //! Field
        //* Fields don't have a get; set; and are typically private
        // private int _milesDriven = 0;

        //! Properties
        //* Properties have a aget; set; and are typically public
        public string Name { get; set; }
        public string Language { get; set; }

        public string Description
        {
            get
            {
                return $"Cohort's {InstructorCohort} instructor is {FirstName } {LastName} @{SlackHandle}, they specialize in {InstructorSpecialty}";
            }
        }