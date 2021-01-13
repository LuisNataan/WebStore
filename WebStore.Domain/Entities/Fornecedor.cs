using WebStore.Domain.Entites;

namespace WebStore.Project.Backend.Domain.Entites
{
    public class Fornecedor : BaseEntity
    {
        public string RazaoSocial { get; protected set; }
        public string NomeFantasia { get; protected set; }
        public string Email { get; protected set; }
        public string Cnpj { get; protected set; }
        public string Telefone { get; protected set; }

        protected Fornecedor()
        {
        }
    }
}
