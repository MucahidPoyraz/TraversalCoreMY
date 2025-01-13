using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<HomeAbout> _genericService;

        public HomeController(IGenericService<HomeAbout> genericService)
        {
            _genericService = genericService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
