using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjeVek.WebUI.Site.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net;

namespace ProjeVek.WebUI.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly string query;

        public IActionResult Index()
        {
            {
                if (string.IsNullOrEmpty(query))
                {
                    return View(new Unsplash());
                }

                var wc = new WebClient();
                var json = wc.DownloadString($"https://unsplash.com/napi/search/photos?query={query}&per_page=20&page=1&xp=");

                var json_model = JsonConvert.DeserializeObject<Unsplash>(json);

                return View(json_model);
            }
        }
    }
}
