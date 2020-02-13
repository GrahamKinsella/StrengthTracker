using System;
using System.Collections.Generic;
using SQLite;

namespace StrengthTracker.Models
{

    //workout - will need an exercise object to give detail to each individual exercise - seperate table? think about it 
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int WorkoutId { get; set; }
        public DateTime Date { get; set; }
        [Ignore]
        public List<Exercise> Exercise { get; set; }
    }
}