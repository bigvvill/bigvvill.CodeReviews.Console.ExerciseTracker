using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using ExerciseTracker.Data;

namespace ExerciseTracker
{
    internal class ExerciseController
    {
        internal void AddSession()
        {
            ExerciseTrackerDbContext context = new();

            Console.WriteLine("dropping into DB\nint Id *\nDateTime DateStart 2022-12-8 08:00:00\nDateTime DateEnd 2022-12-8 08:40:00\nTimeSpan Duration *\nstring Comments Eliptical");

            Exercise exercise = new Exercise();
            exercise.DateStart = DateTime.Parse("2022-12-8 08:00:00");
            exercise.DateEnd = DateTime.Parse("2022-12-8 08:40:00");
            exercise.Comments = "Eliptical";

            context.Exercises.Add(exercise);
            context.SaveChanges();

            Console.WriteLine("\nSession added. Press Enter...");
            Console.ReadLine();
            UserInput userInput = new();
            userInput.MainMenu();
        }

        internal void GetSessions()
        {
            ExerciseTrackerDbContext context = new();

            List<Exercise> exercises= new List<Exercise>();

            foreach (var session in context.Exercises)
            {                
                exercises.Add(session);                
            }

            DisplayTable displayTable = new();
            displayTable.DisplaySessions();
        }
    }
}
