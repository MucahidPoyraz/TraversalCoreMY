using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _SubAboutPartial : ViewComponent
    {
        private readonly IGenericService<SubAbout> _subAboutService;

        public _SubAboutPartial(IGenericService<SubAbout> subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SubAbout> subAbouts = await _subAboutService.GetAllBLAsync();
            return View(subAbouts);
        }
    }
}
