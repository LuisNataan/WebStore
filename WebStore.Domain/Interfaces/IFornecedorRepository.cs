using System.Threading.Tasks;
using WebStore.Project.Backend.Domain.Entites;

namespace WebStore.Project.Backend.Domain.Interfaces
{
    public interface IFornecedorRepository : IGenericRepository<Fornecedor>
    {
        Task<bool> FornecedorJaExiste(string cnpj);
        Task<bool> OutroFornecedorComMesmoCnpj(string cnpj, int id);
        Task<Fornecedor> BuscarFornecedorPorCnpj(string cnpj);
    }
}
