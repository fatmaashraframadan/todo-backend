namespace Domain
{
    public class Entity
    {
        private Guid id;
        private DateTime CreatedAt;
        public virtual Guid Id
        {
            get
            {
                if (id == Guid.Empty)
                    id = Guid.NewGuid();
                return id;
            }
            set => id = value;
        }
        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }
    }
}