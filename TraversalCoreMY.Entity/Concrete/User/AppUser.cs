using Microsoft.AspNetCore.Identity;

namespace TraversalCoreMY.Entity.Concrete.User
{
    public class AppUser : IdentityUser<int>
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
    }
   
}
