using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entidades
{
    public class CategoriaDoProduto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual IList<Produto> Produtos { get; set; }

    }
}
