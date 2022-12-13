using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using ExerciseTracker.Data;

namespace ExerciseTracker
{
    public class ExerciseController
    {
        public void AddSession()
        {
            ExerciseTrackerDbContext context = new();

            UserInput userInput = new();
            Exercise exercise = new();

            exercise = userInput.GetExerciseInput();
            context.Exercises.Add(exercise);
            context.SaveChanges();

            Console.WriteLine("\nSession added. Press Enter...");
            Console.ReadLine();            
            userInput.MainMenu();
        }

        public void GetSessions()
        {
            ExerciseTrackerDbContext context = new();

            UserInput userInput = new();

            List<Exercise> exercises= new();

            foreach (var session in context.Exercises)
            {                
                exercises.Add(session);                
            }

            DisplayTable displayTable = new();
            displayTable.DisplaySessions();

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
            userInput.MainMenu();
        }
    }
}
