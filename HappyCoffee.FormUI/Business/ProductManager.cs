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
    public class ProductManager
    {
        public static HttpClient client = new HttpClient();
        public async static Task<List<Product>> GetProducts(string localAdress,string requestUri)
        {

            client.BaseAddress = new Uri($"{localAdress}");

            //istek attığımızda bize bir cevap döner ve bizde bu cevabı karşılarız.
            HttpResponseMessage response = await client.GetAsync($"{requestUri}");

            //Gelen cevap içeriğini okur ve bir değişkene saklarız.
            string result = await response.Content.ReadAsStringAsync();

            //Sakladığımız değişkeni deserialize ederek ilgili formata çevirerek kullanırız.
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(result);
            return products;
        }

        public async static Task<Product> GetProduct(string localAdress, string requestUri,int id)
        {
            client.BaseAddress = new Uri($"{localAdress}");
            HttpResponseMessage response = await client.GetAsync($"{requestUri}/{id}");
            string result = await response.Content.ReadAsStringAsync();
            Product product = JsonConvert.DeserializeObject<Product>(result);
            return product;
        }
        public async static Task PostProduct(string localAdress, string requestUri,Product product)
        {
            //String content oluşturuyorum. Bu içeriğe json formata dönüştürülmüş verileri string olarak alıyorum. Web apiye düştüğünde
            //içeriği tanıyabilecek ve apide bulunan nesne gönderdiğimiz verileri karşılayabilecek.
            StringContent content = new StringContent(JsonConvert.SerializeObject(product),Encoding.UTF8,"application/json");

            //Adresimi veriyorum. Bu adres localde diğer clientların bizle iletişim kurmasını sağlayan base adresimiz.
            client.BaseAddress = new Uri($"{localAdress}");

            //PostAsync metodu bizden istek atılacak uri haricinde content istiyor. Yani demek istediği; Kardeşim sen beni kullanacaksan
            //içerik vermen lazım yoksa ben boşuna neden bu yolda gideyim diyor. Bu yüzden üst tarafta contentimizi oluşturuyoruz.
            await client.PostAsync($"{requestUri}",content);
        }
    }
}
