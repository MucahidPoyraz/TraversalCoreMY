using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreMY.UI.ViewComponents.Comment
{
    public class _AddCommentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
