//! You must define a type for representing an exercise in code. An exercise can be assigned to many students.
//! Name of exercise
//! Language of exercise (JavaScript, Python, CSharp, etc.)

namespace StudentExercises
{
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public string Language { get; set; }

        public Exercise(string exerciseName, string language)
        {
            ExerciseName = exerciseName;
            Language = language;
        }

    }
}