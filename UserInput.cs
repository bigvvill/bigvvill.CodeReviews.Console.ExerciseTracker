using System;

namespace ExerciseTracker;

public class UserInput
{
    public void MainMenu()
    {
        Console.Clear();

        Console.WriteLine("Welcome to Exercise Tracker!!!");
        Console.WriteLine("\nTrack your Cardio");

        Console.WriteLine("\n0 - Quit");
        Console.WriteLine("1 - Add session");        
        Console.WriteLine("2 - View sessions");

        string menuSelection = Console.ReadLine();

        ExerciseController exerciseController = new ExerciseController();

        switch (menuSelection)
        {
            case "0":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            case "1":                
                exerciseController.AddSession();
                break;
            case "2":                
                exerciseController.GetSessions();
                break;
            default:
                Console.WriteLine("\nPlease enter a valid selection: \"0\", \"1\", or \"2\"\nPress Enter...");
                Console.ReadLine();
                MainMenu();
                break;
        }


        Console.WriteLine("\nEnter start time of session:");
    }
}
