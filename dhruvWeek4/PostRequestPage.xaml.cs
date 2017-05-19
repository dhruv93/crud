using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dhruvWeek4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostRequestPage : ContentPage
    {
        public PostRequestPage()
        {
            InitializeComponent();
            //bindingContext = this;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {

            ItemRestClientService client = new ItemRestClientService();
            var req = (ItemPostRequest)BindingContext;
            List<Item> items = await client.PostCharForPostClient(req);
            await App.Database.PopulateDB(items);
            await Navigation.PushAsync(new ItemsListPage());

        }
    }
}