namespace TraversalCoreMY.Entity.Concrete.Home
{
    public class Testimonial : BaseEntity
    {
        public string ClientName { get; set; }  // Client yerine daha açıklayıcı
        public string Comment { get; set; }
        public string ClientImageUrl { get; set; }  // Image yerine ImageUrl
        public bool IsActive { get; set; }  // Status yerine boolean için uygun isimlendirme
    }
}
