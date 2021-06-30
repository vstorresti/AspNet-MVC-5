using System.Collections.Generic;
using VTorres.Business.Core.Models;
using VTorres.Business.Models.Enums;
using VTorres.Business.Models.Produtos;

namespace VTorres.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
