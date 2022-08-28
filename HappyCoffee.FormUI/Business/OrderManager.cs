using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.FormUI.Business
{
    public static class OrderManager
    {
        public static HttpClient client = new HttpClient();

        public async static Task<List<HappyCoffee.FormUI.Models.Order>> GetProducts(string localAdress, string requestUri)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            HttpResponseMessage response = await client.GetAsync($"{requestUri}");
            string result = await response.Content.ReadAsStringAsync();
            List< HappyCoffee.FormUI.Models.Order> orders = JsonConvert.DeserializeObject<List<HappyCoffee.FormUI.Models.Order>>(result);
            return orders;
        }



        public async static Task<HappyCoffee.FormUI.Models.Order> GetProduct(string localAdress, string requestUri, int id)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            HttpResponseMessage response = await client.GetAsync($"{requestUri}/{id}");
            string result = await response.Content.ReadAsStringAsync();
            HappyCoffee.FormUI.Models.Order order = JsonConvert.DeserializeObject<HappyCoffee.FormUI.Models.Order>(result);
            return order;
        }


        public async static Task AddOrder(string localAdress, string requestUri, HappyCoffee.FormUI.Models.Order order)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri($"{localAdress}");
            await client.PostAsync($"{requestUri}", content);
        }



        public async static Task UpdateOrder(string localAdress, string requestUri, HappyCoffee.FormUI.Models.Order order)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri($"{localAdress}");
            await client.PutAsync($"{requestUri}", content);
        }



        public async static Task CancelOrder(string localAdress, string requestUri,int id)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            await client.DeleteAsync($"{requestUri}/{id}");
        }


    }
}
