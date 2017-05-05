using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
	public partial class ItemPage : ContentPage
	{
		public ItemPage()
		{
			InitializeComponent();
		}

		async void Save_Clicked(object sender, System.EventArgs e)
		{
			var ItemRow = (Item)BindingContext;
			await App.Database.InsertItem(ItemRow);
			await Navigation.PopAsync();
		}

		async void Cancel_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopAsync();
		}

	}
}
