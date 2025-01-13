using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TraversalCoreMY.BL.Abstract;
using TraversalCoreMY.Entity.Concrete.About;
using TraversalCoreMY.Entity.Concrete.Home;
using TraversalCoreMY.UI.Model;

namespace TraversalCoreMY.UI.ViewComponents.Home
{
    public class _StatisticsPartial : ViewComponent
    {
        private readonly IGenericService<Destination> _destinationService;
        private readonly IGenericService<Guide> _guideService;

        private const int CustomerCount = 250;
        private const int AwardCount = 500;

        public _StatisticsPartial(IGenericService<Destination> destinationService, IGenericService<Guide> guideService)
        {
            _destinationService = destinationService;
            _guideService = guideService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Statistic statistic = new Statistic();

            List<Destination> destinations = await _destinationService.GetAllBLAsync() ?? new List<Destination>();
            List<Guide> guides = await _guideService.GetAllBLAsync() ?? new List<Guide>();

            statistic.DestinationCount = destinations.Count;
            statistic.GuideCount = guides.Count;
            statistic.CustomerCount = CustomerCount;
            statistic.AwardCount = AwardCount;

            return View(statistic);
        }
    }
}
