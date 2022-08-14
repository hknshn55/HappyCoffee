using HappyCoffee.FormUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.FormUI.Business
{
   public static  class CategoryManager
    {
        static HttpClient client = new HttpClient();
        public async static Task<List<Category>> Categories(string localAdress, string requestUri)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            HttpResponseMessage response = await client.GetAsync($"{requestUri}");
            string result = await response.Content.ReadAsStringAsync();
            Console.Write(result);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(result);
            return categories;
        }
        public async static Task<Category> GetCategory(string localAdress, string requestUri,int id)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            HttpResponseMessage response = await client.GetAsync($"{requestUri}/{id}");
            string result = await response.Content.ReadAsStringAsync();
            Category category = JsonConvert.DeserializeObject<Category>(result);
            return category;
        }

    }
}
