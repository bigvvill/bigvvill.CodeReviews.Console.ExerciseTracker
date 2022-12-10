using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
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
    }

    internal Exercise GetExerciseInput()
    {
        Console.WriteLine("New Session");
        Console.WriteLine("\nEnter start time of session (format: yyyy-mm-dd hh:mm:ss) or 0 to return to Menu:");
        string startTimeInput = Console.ReadLine();

        if (startTimeInput == "0")
        {
            MainMenu();
        }

        while (startTimeInput == null || !Validation.IsValidDateTime(startTimeInput))
        {
            Console.WriteLine("Please enter a date and time in the format (yyyy-mm-dd hh:mm:ss) or 0 to return to Menu:");
            startTimeInput= Console.ReadLine();

            if (startTimeInput == "0")
            {
                MainMenu();
            }
        }

        Console.WriteLine("\nEnter end time of session (format: yyyy-mm-dd hh:mm:ss) or 0 to return to Menu:");
        string endTimeInput = Console.ReadLine();

        if (endTimeInput == "0")
        {
            MainMenu();
        }

        while (endTimeInput == null || !Validation.IsValidDateTime(endTimeInput))
        {
            Console.WriteLine("Please enter a date and time in the format (yyyy-mm-dd hh:mm:ss) or 0 to return to Menu:");
            endTimeInput = Console.ReadLine();

            if (endTimeInput == "0")
            {
                MainMenu();
            }
        }

        Console.WriteLine("\nEnter comments or 0 to return to Menu:");
        string comments = Console.ReadLine();

        Exercise exercise = new Exercise();
        exercise.DateStart = DateTime.Parse(startTimeInput);
        exercise.DateEnd = DateTime.Parse(endTimeInput);
        exercise.Comments = comments;

        return exercise;
    }
}
