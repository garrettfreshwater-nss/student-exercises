using System.Collections.Generic;
namespace StudentExercises
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int StudentCohort { get; set; }
        public List<Exercises> Exercises = new List<Exercises>();

        //methods
        public void addExercises(Exercises name)
        {
            Exercises.Add(name);
        }
    }
}