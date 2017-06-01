using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entidades
{
    public class Produto
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public virtual CategoriaDoProduto Categoria { get; set; }
        public int? CategoriaID { get; set; }
        public String Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}
