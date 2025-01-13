using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        private readonly IGenericService<Destination> _genericService;

        public _PopularDestinationsPartial(IGenericService<Destination> genericService)
        {
            _genericService = genericService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var destinations = await _genericService.GetAllBLAsync();
            return View(destinations);
        }
    }
}
