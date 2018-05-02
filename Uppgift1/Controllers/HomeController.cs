using System.Web.Mvc;
using Newtonsoft.Json;
using Uppgift1.Models;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uppgift1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public  async Task<ActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
                string content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var model = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                    return View(model);
                }
                return Content("An error has occurred: " + content);
            }
        }
    }
}