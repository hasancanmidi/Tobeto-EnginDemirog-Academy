namespace Core.Entities
{
    public class Entity<TId> : IEntityTimestamps
    {
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; } //Soru işareti null alabilir anlamına gelmektedir.
        public DateTime? DeletedDate { get; set; }

        public Entity()
        {
            Id = default;
        }

        public Entity(TId id)
        {
            Id = id;
        }
    }
}