namespace Todo.Domain.Entities
{
    public abstract class Entity: IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        private Guid Id { get; set; }

        public bool Equals(Entity? other)
        {
            return Id == other?.Id;
        }
    }    
}
