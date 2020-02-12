using System;
using SQLite;

namespace StrengthTracker.Models
{

    //workout - will need an exercise object to give detail to each individual exercise - seperate table? think about it 
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}