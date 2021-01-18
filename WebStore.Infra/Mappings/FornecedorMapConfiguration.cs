using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Project.Backend.Domain.Entites;

namespace WebStore.Project.Backend.Infra.Mappings
{
    public class FornecedorMapConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");

            builder.Property(f => f.NomeFantasia)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(f => f.RazaoSocial)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(f => f.Email)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(f => f.Cnpj)
                .IsFixedLength()
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(f => f.Telefone)
                .IsFixedLength()
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
