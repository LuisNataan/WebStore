namespace WebStore.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public bool Deletado { get; protected set; }
    }
}
