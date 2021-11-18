using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        public AboutViewModel()
        {
            JasonsRolls = new ObservableCollection<int>();
            GregsRolls = new ObservableCollection<int>();
            MilksRolls = new ObservableCollection<int>();

            JasonsRollDiceCommand = new Command(() => {
                JasonsRolls.Add(JasonsRoll);
                JasonsRoll = diceRoller();
            });

            GregsRollDiceCommand = new Command(() => {
                GregsRolls.Add(GregsRoll);
                GregsRoll = diceRoller();
            });

            MilksRollDiceCommand = new Command(() => {
                MilksRolls.Add(MilksRoll);
                MilksRoll = diceRoller();
            });


            ResetRollsCommand = new Command(() => {
                GregsRolls.Add(RollResetOne);
                JasonsRolls.Add(RollResetOne);
                MilksRolls.Add(RollResetOne);
                RollResetOne = 0;
            });


        }
        public ObservableCollection<int> JasonsRolls { get; set; }
        public ObservableCollection<int> GregsRolls { get; set; }
        public ObservableCollection<int> MilksRolls { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        int roll;

        public int JasonsRoll
        {
            get => roll;
            set
            {
                roll = diceRoller();
                var args = new PropertyChangedEventArgs(nameof(JasonsRoll));

                PropertyChanged?.Invoke(this, args);
            }
        }
        public int GregsRoll
        {
            get => roll;
            set
            {
                roll = diceRoller();
                var args = new PropertyChangedEventArgs(nameof(GregsRoll));

                PropertyChanged?.Invoke(this, args);
            }
        }
        public int MilksRoll
        {
            get => roll;
            set
            {
                roll = diceRoller();
                var args = new PropertyChangedEventArgs(nameof(MilksRoll));

                PropertyChanged?.Invoke(this, args);
            }
        }
        public int RollResetOne
        {
            get => roll;
            set
            {
                roll = 0;
                var args1 = new PropertyChangedEventArgs(nameof(JasonsRoll));
                var args2 = new PropertyChangedEventArgs(nameof(GregsRoll));
                var args3 = new PropertyChangedEventArgs(nameof(MilksRoll));

                PropertyChanged?.Invoke(this, args1);
                PropertyChanged?.Invoke(this, args2);
                PropertyChanged?.Invoke(this, args3);
            }
        }
        public int diceRoller()
        {
            Random r = new Random();
            int diceRoll = r.Next(1, 60);
            return diceRoll;
        }
        public Command JasonsRollDiceCommand { get; }
        public Command GregsRollDiceCommand { get; }
        public Command MilksRollDiceCommand { get; }
        public Command ResetRollsCommand { get; }
    }
}