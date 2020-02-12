using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using StrengthTracker.Models;

namespace StrengthTracker.Data
{
    public class WorkoutDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public WorkoutDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Workout>().Wait();
        }

        public Task<List<Workout>> GetWorkoutAsync()
        {
            return _database.Table<Workout>().ToListAsync();
        }

        public Task<Workout> GetWorkoutAsync(int id)
        {
            return _database.Table<Workout>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveWorkoutAsync(Workout workout)
        {
            if (workout.ID != 0)
            {
                return _database.UpdateAsync(workout);
            }
            else
            {
                return _database.InsertAsync(workout);
            }
        }

        public Task<int> DeleteWorkoutAsync(Workout workout)
        {
            return _database.DeleteAsync(workout);
        }
    }
}