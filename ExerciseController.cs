﻿using bigvvill.CodeReviews.Console.ExerciseTracker.Models;

namespace ExerciseTracker
{
    internal class ExerciseController
    {
        internal void AddSession()
        {


            Console.WriteLine("dropping into DB\nint Id *\nDateTime DateStart 2022-12-8 08:00:00\nDateTime DateEnd 2022-12-8 08:40:00\nTimeSpan Duration *\nstring Comments Eliptical");

            Exercise exercise = new Exercise();
            exercise.DateStart = DateTime.Parse("2022-12-8 08:00:00");
            exercise.DateEnd = DateTime.Parse("2022-12-8 08:40:00");
            exercise.Comments = "Eliptical";

            List<Exercise> exercises= new List<Exercise>();
            exercises.Add(exercise);

            
        }

        internal void GetSessions()
        {
            Console.WriteLine("Bye");
        }
    }
}
