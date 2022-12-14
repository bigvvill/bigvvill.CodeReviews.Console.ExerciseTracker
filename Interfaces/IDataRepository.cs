using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Interfaces
{
    public interface IDataRepository
    {
        List<Exercise> AddExercise(ExerciseController exercise);
        List<Exercise> GetExercise();
        Exercise PutExercise(Exercise exercise);
        Exercise GetExerciseById(int id);
    }
}
