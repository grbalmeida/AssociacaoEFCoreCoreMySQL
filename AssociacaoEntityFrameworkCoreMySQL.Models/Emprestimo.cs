using System;
using System.Collections.Generic;

namespace AssociacaoEntityFrameworkCoreMySQL.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int? EmprestimoAnteriorId { get; set; }
        public Emprestimo EmprestimoAnterior { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataLimiteDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }

        /* EF - Relationship */
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
