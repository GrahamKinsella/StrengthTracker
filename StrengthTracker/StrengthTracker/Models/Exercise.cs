using SQLite;

namespace StrengthTracker.Models
{
    public class Exercise
    {
        [PrimaryKey, AutoIncrement]
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public int Reps { get; set; }
        public int WorkoutId { get; set; }
    }
}
