using System;
using System.IO;
using Xamarin.Forms;
using StrengthTracker.Data;

namespace StrengthTracker
{
    public partial class App : Application
    {
        static WorkoutDatabase database;

        public static WorkoutDatabase Database
        {
            get
            {
                if (database == null)
                {
                    //TODO: Move database name to configuration - not hardcoded
                    database = new WorkoutDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Workout.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new WorkoutPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}