using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
	public partial class UpdateItemsPage : ContentPage
	{
		public UpdateItemsPage()
		{
			InitializeComponent();
            this.Title = "Update";
		}

		protected async override void OnAppearing()
		{
		base.OnAppearing();
		UpdateItemListView.ItemsSource = await App.Database.RetrieveItems();
		}



		async void Items_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				await Navigation.PushAsync(new UpdateItems() { BindingContext = e.SelectedItem as Item });
			}
				}
			}
}
