namespace TraversalCoreMY.Entity.Concrete.Home
{
    public class Destination : BaseEntity
    {
        public string CityName { get; set; }
        // Gündüz ve gece konsepti açıklayıcı şekilde yeniden adlandırıldı
        public string Duration { get; set; }
        // Para birimi tutarken decimal kullanmak daha uygundur
        public decimal Price { get; set; }
        // Birden fazla resim eklenebilir mi? Koleksiyon kullanılabilir.
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}
