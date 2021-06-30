using System.Data.Entity.ModelConfiguration;
using VTorres.Business.Models.Produtos;

namespace VTorres.Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.Imagem)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
