using Microsoft.AspNetCore.Mvc;

namespace RapidApiProject.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USDT&to=TRY&q=1.0"),
                Headers =
    {
        { "X-RapidAPI-Key", "baec683ea0msh79a13f8005f2b44p1d4f7cjsnb5bfc71b239e" },
        { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.v = body;

            }
            return View();

        }
    }
}

/*Kur başlıkları dropdown'a enum liste üzerinden aktarılsın 
             1.dd neyden
             2.dd neye
            seçilen kurlara göre kur bilgisi getiren uygulamayı yazın*/



