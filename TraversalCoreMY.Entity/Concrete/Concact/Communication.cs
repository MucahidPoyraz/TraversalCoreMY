namespace TraversalCoreMY.Entity.Concrete.Concact
{
    public class Communication : BaseEntity
    {
        public string Description { get; set; }
        public string Email { get; set; }  // Mail yerine daha doğru bir terim
        public string Address { get; set; }
        public string PhoneNumber { get; set; }  // Phone yerine daha açıklayıcı
        public string MapLocationUrl { get; set; }  // Konumu ifade eden URL için daha net ad
        public bool IsActive { get; set; }  // Status yerine boolean için uygun isim
    }
}
