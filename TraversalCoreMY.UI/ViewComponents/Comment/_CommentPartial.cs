using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;

namespace TraversalCoreMY.UI.ViewComponents.Comment
{
    public class _CommentPartial : ViewComponent
    {
        private readonly IGenericService<TraversalCoreMY.Entity.Concrete.Blog.Comment> _commentService;

        public _CommentPartial(IGenericService<Entity.Concrete.Blog.Comment> commentService)
        {
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var gelen = await _commentService.GetAllBLAsync(x=>x.Id == id);
            return View();
        }
    }
}
