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
            var note = (Workout)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.Database.SaveWorkoutAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Workout)BindingContext;
            await App.Database.DeleteWorkoutAsync(note);
            await Navigation.PopAsync();
        }
    }
}