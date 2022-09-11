using HappyCoffee.Entities.Concrete;
using HappyCoffee.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HappyCoffee.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8891/");
            HttpResponseMessage response = client.GetAsync($"api/Product/{id}").Result;
            string result = response.Content.ReadAsStringAsync().Result;
            Product product = JsonConvert.DeserializeObject<Product>(result);
            return View(product);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
