using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IGenericService<Featured> _featuredService;

        public _FeaturePartial(IGenericService<Featured> featuredService)
        {
            _featuredService = featuredService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Featured> featureds = await _featuredService.GetAllBLAsync();
            return View(featureds);
        }
    }
}
