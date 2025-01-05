namespace TraversalCoreMY.Entity.Concrete.Home
{
    public class HomeAbout : BaseEntity
    {
        public string MainTitle { get; set; }
        public string MainDescription { get; set; }
        public string SecondaryTitle { get; set; }
        public string SecondaryDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
