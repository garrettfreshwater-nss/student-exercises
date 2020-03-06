//! A method to assign an exercise to a student

namespace StudentExercises
{
    public class Instructor
    {
        //! Field
        //* Fields don't have a get; set; and are typically private
        // private int _milesDriven = 0;

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
        //  public Car(int milesDriven, string make, string model, int year)
        // {
        //     _milesDriven = milesDriven;
        //     Make = make;
        //     Model = model;
        //     Year = year;
        // }

        // public void Drive(int miles)
        // {
        //     _milesDriven += miles;

        //     if (_milesDriven > 10000)
        //     {
        //         NeedsMaintenance = true;
        //     }
        // }
        // public void Service(bool addCleaningService) // method overloading
        // {
        //     NeedsMaintenance = false;

        //     if (addCleaningService)
        //     {
        //         IsClean = true;
        //     }
        // }

        // This is a constructor. It doesn't have a return type
        // and the name of the method is the same as the name of the class
        // public Car(int milesDriven)
        // {
        //     _milesDriven = milesDriven;
        // }

    }
}