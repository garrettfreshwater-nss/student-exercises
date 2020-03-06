namespace StudentExercises
{
    public class Instructor
    {
        //! Properties
        //* Properties have a aget; set; and are typically public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int InstructorCohort { get; set; }
        public string InstructorSpecialty { get; set; }

        public string Description
        {
            get
            {
                return $"Cohort's {InstructorCohort} instructor is {FirstName } {LastName} @{SlackHandle}, they specialize in {InstructorSpecialty}";
            }
        }
        // Constructor to make adding info easier
        public Instructor(string firstName, string lastName, string slackHandle, int instructorCohort, string instructorSpecialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            InstructorCohort = instructorCohort;
            InstructorSpecialty = instructorSpecialty;
        }

        // A method to assign an exercise to a student
        public void AddStudentExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}