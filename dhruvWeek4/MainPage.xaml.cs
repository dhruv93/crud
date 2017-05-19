using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhruvWeek4
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.Title = "Main Page";
		}

		async void Create_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ItemPage() { BindingContext = new Item() });
		}
		async void Read_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ItemsListPage());
		}
		async void Update_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new UpdateItemsPage() );
		}
		async void Delete_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new DeleteItemsPage() );
		}
        async void Post_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PostRequestPage() { BindingContext = new ItemPostRequest() });
        }

    }
}
