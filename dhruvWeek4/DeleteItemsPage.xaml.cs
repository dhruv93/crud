using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
	public partial class DeleteItemsPage : ContentPage
	{
		public DeleteItemsPage()
		{
			InitializeComponent();
            this.Title = "Delete";
		}
		protected async override void OnAppearing()
		{
		base.OnAppearing();
		DeleteItemListView.ItemsSource = await App.Database.RetrieveItems();
		}

		async void Items_Selected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
		if (e.SelectedItem != null)
		{
		    await Navigation.PushAsync(new DeleteItems() { BindingContext = e.SelectedItem as Item });
		}
		}
	}
}
