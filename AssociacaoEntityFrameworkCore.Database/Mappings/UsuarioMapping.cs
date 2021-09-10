using AssociacaoEntityFrameworkCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssociacaoEntityFrameworkCore.Database.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Senha)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.DataNascimento)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.Endereco)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Estado)
                .HasColumnType("CHAR(8)")
                .IsRequired();

            builder.Property(p => p.Pais)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.CEP)
                .HasColumnType("CHAR(8)")
                .IsRequired();

            builder.Property(p => p.Fone)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.Property(p => p.Imagem)
                .HasColumnType("VARCHAR(100)");
        }
    }
}
