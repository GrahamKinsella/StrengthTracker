using StrengthTracker.Models;
using System;
using System.IO;
using Xamarin.Forms;

namespace StrengthTracker
{
    public partial class WorkoutEntryPage : ContentPage
    {
        public WorkoutEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var workout = (Workout)BindingContext;
            workout.Date = DateTime.UtcNow;
            await App.Database.SaveWorkoutAsync(workout);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var workout = (Workout)BindingContext;
            await App.Database.DeleteWorkoutAsync(workout);
            await Navigation.PopAsync();
        }
    }
}