using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Project.Backend.Domain.ComplexType;

namespace WebStore.Project.Backend.Infra.Mappings
{
    public class EnderecoMapConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.Property(e => e.Rua)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.Bairro)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.Cidade)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.Cep)
                .HasColumnName("CEP")
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(e => e.UF)
                .IsFixedLength()
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(e => e.Numero)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
