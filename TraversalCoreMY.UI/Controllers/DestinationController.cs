using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Blog;

namespace TraversalCoreMY.UI.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IGenericService<Destination> _destinationService;

        public DestinationController(IGenericService<Destination> destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetail(int id) 
        {
            Destination destination = await _destinationService.GetByIdBLAsync(id);
            return View(destination);
        }
    }
}
