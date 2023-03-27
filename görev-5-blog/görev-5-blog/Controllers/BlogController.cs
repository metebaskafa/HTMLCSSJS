using görev_5_blog.Models;
using Microsoft.AspNetCore.Mvc;


namespace görev_5_blog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult BlogDetay()
        {
            BlogYazisi blogYazisi = new();
            blogYazisi.ID = 1;
            blogYazisi.Baslik = "youtube";
            blogYazisi.Icerik = "Öncelikle YouTube üzerinden bir kanal sahibi olan kişiler, abonelerine yönelik ilgi çekici videolar yüklemelidir. Bu sayede kullanıcılar kendilerini daha değerli hissederek kanalınıza abone olup izlenme sayınızı arttırabilir. YouTube üzerinden yüklediğiniz ilgi çekici içerikler sayesinde kullanıcılarınıza belli başlı yönergeler vermeyi düşünebilirsiniz. Neredeyse her YouTube kanal sahibi kişilerin kurduğu cümlelerden biri olan ‘kanalıma abone olun’ ifadesini videolarınıza yerleştirebilirsiniz. YouTube izlenme taktikleri kullanıcıları kendine çekeceği için kanalınıza abone olup izlenme sayınızın arttırabilirler.";
            return View(blogYazisi);

        }
        [HttpPost]
        public IActionResult BlogDetay(BlogYazisi blogYazisi)  
        {
            return View(blogYazisi); 
        }
    }
}
