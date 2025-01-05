using System;

namespace TraversalCoreMY.Entity.Concrete
{
    public abstract class BaseEntity
    {
        // Benzersiz kimlik özelliği
        public int Id { get; set; }

        // Oluşturulma zamanı
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Güncellenme zamanı
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Silinme durumu (Soft delete için)
        public bool IsDeleted { get; set; } = false;

        // Common metot: Güncelleme zamanını ayarla
        public void SetUpdatedTime()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
