using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhruvWeek4
{
    public class ItemRestClientService
    {
        public async Task<List<Item>> GetItemsFromRestClient(int i)
        {


            RestClient<Item> restClient = new RestClient<Item>();

            var ItemList = await restClient.GetAsync(i);
            return ItemList;
        }

        public async Task<List<Item>> PostCharForPostClient(ItemPostRequest req)
        {


            RestClient<Item> restClient = new RestClient<Item>();

            var ItemList = await restClient.PostAsync(req);
            return ItemList;
        }

    }
}
