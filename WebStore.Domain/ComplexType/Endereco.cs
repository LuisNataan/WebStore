namespace WebStore.Domain.ComplexType
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; protected set; }
        public string Bairro { get; protected set; }
        public string Cidade { get; protected set; }
        public string Cep { get; protected set; }
        public string UF { get; protected set; }
        public int Numero { get; protected set; }
        public string Complemento { get; protected set; }

        protected Endereco()
        {
        }
    }
}
