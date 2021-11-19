using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string text;
        private string description;
        private string jasonsScore;
        private string gregsScore;
        private string milksScore;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description)
                && !String.IsNullOrWhiteSpace(jasonsScore)
                && !String.IsNullOrWhiteSpace(gregsScore)
                && !String.IsNullOrWhiteSpace(milksScore);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string JasonsScore
        {
            get => jasonsScore;
            set => SetProperty(ref jasonsScore, value);
        }
        public string MilksScore
        {
            get => milksScore;
            set => SetProperty(ref milksScore, value);
        }
        public string GregsScore
        {
            get => gregsScore;
            set => SetProperty(ref gregsScore, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description,
                GregsScore = GregsScore,
                JasonsScore = JasonsScore,
                MilksScore = MilksScore
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
