using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            JasonsWincount.Items.Add("1");
            JasonsWincount.Items.Add("2");
            JasonsWincount.Items.Add("3");
            JasonsWincount.Items.Add("4");
            JasonsWincount.Items.Add("5");

            GregsWincount.Items.Add("1");
            GregsWincount.Items.Add("2");
            GregsWincount.Items.Add("3");
            GregsWincount.Items.Add("4");
            GregsWincount.Items.Add("5");

            MilksWincount.Items.Add("1");
            MilksWincount.Items.Add("2");
            MilksWincount.Items.Add("3");
            MilksWincount.Items.Add("4");
            MilksWincount.Items.Add("5");

        }
    }
}