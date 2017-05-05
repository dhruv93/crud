using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
	public partial class DeleteItems : ContentPage
	{
		public DeleteItems()
		{
			InitializeComponent();
		}

		async void Delete_Clicked(object sender, System.EventArgs e)
		{
		var ItemRow = (Item)BindingContext;
		await App.Database.deleteItem(ItemRow);
		await Navigation.PopAsync();
		}

		async void Cancel_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
