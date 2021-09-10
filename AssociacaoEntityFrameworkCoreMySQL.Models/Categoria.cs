using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssociacaoEntityFrameworkCoreMySQL.Models
{
    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nome { get; set; }

        /* EF - Relationship */

        public ICollection<Produto> Produtos { get; set; }
    }
}
