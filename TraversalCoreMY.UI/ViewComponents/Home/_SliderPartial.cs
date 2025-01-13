using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _SliderPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
