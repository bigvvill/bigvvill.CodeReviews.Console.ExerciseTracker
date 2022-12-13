using bigvvill.CodeReviews.Console.ExerciseTracker.Models;
using ExerciseTracker.Data;
using ExerciseTracker.Interfaces;

namespace ExerciseTracker
{
    public class ExerciseRepository : IDataRepository
    {
        private readonly ExerciseTrackerDbContext db;

        public ExerciseRepository(ExerciseTrackerDbContext db)
        {
            this.db = db;
        }

        List<Exercise> IDataRepository.AddExercise(ExerciseController exercise)
        {
            throw new NotImplementedException();
        }

        List<Exercise> IDataRepository.GetExercise()
        {
            throw new NotImplementedException();
        }

        Exercise IDataRepository.GetExerciseById(int id)
        {
            throw new NotImplementedException();
        }

        Exercise IDataRepository.PutExercise(Exercise exercise)
        {
            throw new NotImplementedException();
        }
    }
}
