using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dhruvWeek4
{
    public class RestClient<T>
    {
        private const string WebServiceUrl = "http://thursdayhomework.azurewebsites.net/API/GetItemList/";
        private const string WebServicePostUrl = "http://thursdayhomeworkpost.azurewebsites.net/api/GetItems";

        public async Task<List<Item>> GetAsync(int i)
        {
            HttpClient httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl + i);

            var taskModels = JsonConvert.DeserializeObject<APIItemResponse>(json);

            return taskModels.data;
        }

        public async Task<List<Item>> PostAsync(ItemPostRequest req)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(req);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var jsonresult = await httpClient.PostAsync(WebServicePostUrl, httpContent);
            var taskModels = JsonConvert.DeserializeObject<APIItemResponse>(jsonresult.Content.ReadAsStringAsync().Result);
            return taskModels.data;
        }

    }
}
