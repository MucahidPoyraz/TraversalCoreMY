namespace TraversalCoreMY.Entity.Concrete.Home
{
    public class Featured : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }  // Daha açıklayıcı adlandırma
        public bool IsActive { get; set; }    // Boolean için açıklayıcı isim
    }
}
