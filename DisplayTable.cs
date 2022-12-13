using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using ConsoleTableExt;
using ExerciseTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public class DisplayTable
    {
        public static void ShowSessions<T>(List<T> tableData) where T : class
        {
            ConsoleTableBuilder
                .From(tableData)
                .WithTitle("Sessions")
                .ExportAndWriteLine();
        }

        public void DisplaySessions()
        {
            Console.Clear();

            var context = new ExerciseTrackerDbContext();

            List<Exercise> sessions = new();

            foreach (var session in context.Exercises)
            {
                sessions.Add(session);
            }

            ShowSessions(sessions);
        }
    }
}
