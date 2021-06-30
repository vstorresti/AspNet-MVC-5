using System;
using System.Threading.Tasks;
using VTorres.Business.Core.Data;

namespace VTorres.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
