using App2.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description; 
        private string jasonsScore;
        private string milksScore;
        private string gregsScore;
        public string Id { get; set; }

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

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                JasonsScore = item.JasonsScore;
                GregsScore = item.GregsScore;
                MilksScore = item.MilksScore;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
