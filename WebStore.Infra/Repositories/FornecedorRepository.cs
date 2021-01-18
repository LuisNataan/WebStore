using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebStore.Project.Backend.Domain.Entites;
using WebStore.Project.Backend.Domain.Interfaces;
using WebStore.Project.Backend.Infra.Repositories.GenericRepository;

namespace WebStore.Project.Backend.Infra.Repositories
{
    public class FornecedorRepository : GenericRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MainContext context) : base(context)
        {
        }

        public override async Task<Fornecedor> GetById(int id)
        {
            return await _dbSet
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id && !f.Deletado);
        }

        public async Task<Fornecedor> BuscarFornecedorPorCnpj(string cnpj)
        {
            return await Query().FirstOrDefaultAsync(f => f.Cnpj == cnpj);
        }

        public async Task<bool> FornecedorJaExiste(string cnpj)
        {
            return await Query().AnyAsync(f => f.Cnpj == cnpj && !f.Deletado);
        }

        public async Task<bool> OutroFornecedorComMesmoCnpj(string cnpj, int id)
        {
            return await Query().AnyAsync(f => f.Cnpj == cnpj && f.Id == id && !f.Deletado);
        }
    }
}
