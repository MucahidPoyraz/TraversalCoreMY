namespace TraversalCoreMY.Entity.Concrete.About
{
    public class Guide : BaseEntity
    {
        public string FullName { get; set; }  
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string TwitterProfileUrl { get; set; }
        public string InstagramProfileUrl { get; set; }
        public bool IsActive { get; set; } 
    }
}
