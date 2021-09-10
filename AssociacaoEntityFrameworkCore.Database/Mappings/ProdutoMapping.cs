using AssociacaoEntityFrameworkCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssociacaoEntityFrameworkCore.Database.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("TEXT");

            builder.Property(p => p.Ativo)
                .HasColumnType("BIT")
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnType("DECIMAL(10, 2)")
                .IsRequired();

            builder.Property(p => p.CategoriaId)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.QuantidadeEstoque)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.Altura)
                .HasColumnType("DECIMAL(4, 2)")
                .IsRequired();

            builder.Property(p => p.Largura)
                .HasColumnType("DECIMAL(4, 2)")
                .IsRequired();

            builder.Property(p => p.Profundidade)
                .HasColumnType("DECIMAL(4, 2)")
                .IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId)
                .HasConstraintName("FK_Categoria");
        }
    }
}
