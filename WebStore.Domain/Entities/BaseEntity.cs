namespace WebStore.Domain.Entites
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public bool Deletado { get; protected set; }
    }
}
