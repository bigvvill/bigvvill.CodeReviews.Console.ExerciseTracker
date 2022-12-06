using System.ComponentModel.DataAnnotations;

namespace bigvvill.CodeReviews.Console.ExerciseTracker.Models
{
    internal class Exercise
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public string Comments { get; set; }

    }
}
