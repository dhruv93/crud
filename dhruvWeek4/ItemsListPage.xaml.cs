using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
    public partial class ItemsListPage : ContentPage
    {
        public ItemsListPage()
        {
            InitializeComponent();
            this.Title = "Item List";
        
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ItemListView.ItemsSource = await App.Database.RetrieveItems();
        }

        async void Items_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ReadItems() { BindingContext = e.SelectedItem as Item });
            }
        }
    }
}
