using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
