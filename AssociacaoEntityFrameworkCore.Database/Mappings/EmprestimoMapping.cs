using AssociacaoEntityFrameworkCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssociacaoEntityFrameworkCore.Database.Mappings
{
    public class EmprestimoMapping : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ProdutoId)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.ClienteId)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.UsuarioId)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(p => p.EmprestimoAnteriorId)
                .HasColumnType("INT");

            builder.Property(p => p.EmprestimoAnteriorId)
                .HasColumnType("INT");

            builder.Property(p => p.DataEmprestimo)
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .IsRequired();

            builder.Property(p => p.DataLimiteDevolucao)
                .HasColumnType("DATETIME");

            builder.Property(p => p.DataDevolucao)
                .HasColumnType("DATETIME");

            builder.HasOne(p => p.Produto)
                .WithMany(p => p.Emprestimos)
                .HasForeignKey(p => p.ProdutoId)
                .HasConstraintName("FK_Produto")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Emprestimos)
                .HasForeignKey(p => p.ClienteId)
                .HasConstraintName("FK_Cliente")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.Emprestimos)
                .HasForeignKey(p => p.UsuarioId)
                .HasConstraintName("FK_Usuario")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.EmprestimoAnterior)
                .WithMany(p => p.Emprestimos)
                .HasForeignKey(p => p.EmprestimoAnteriorId)
                .HasConstraintName("FK_EmprestimoAnterior")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasCheckConstraint("CH_DataLimiteDevolucao", "DataLimiteDevolucao > DataEmprestimo");

            builder.HasCheckConstraint("CH_DataDevolucao", "DataDevolucao > DataEmprestimo");
        }
    }
}
