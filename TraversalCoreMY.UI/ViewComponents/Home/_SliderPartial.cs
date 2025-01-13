using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
