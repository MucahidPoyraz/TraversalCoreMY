using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.Home;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly IGenericService<Testimonial> _testimonialService;

        public _TestimonialPartial(IGenericService<Testimonial> testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Testimonial> testimonials = await _testimonialService.GetAllBLAsync();
            return View(testimonials);
        }
    }
}
