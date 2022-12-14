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

        public List<Exercise> AddExercise(Exercise exercise)
        {
            db.Exercises.Add(exercise);
            db.SaveChanges();
            return db.Exercises.ToList();
        }

        public List<Exercise> GetExercises()=> db.Exercises.ToList();        

        public Exercise GetExerciseById(int id)
        {
            return db.Exercises.Where(x=>x.Id == id).FirstOrDefault();
        }

        public Exercise PutExercise(Exercise exercise)
        {
            db.Exercises.Update(exercise);
            db.SaveChanges();
            return db.Exercises.Where(x => x.Id == exercise.Id).FirstOrDefault();
        }
    }
}
