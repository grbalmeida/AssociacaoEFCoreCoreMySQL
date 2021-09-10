using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssociacaoEntityFrameworkCoreMySQL.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Profundidade { get; set; }

        /* EF - Relationship */
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
