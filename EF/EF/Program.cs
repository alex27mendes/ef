using EF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadeContext contexto = new EntidadeContext();
            /* contexto.Database.CreateIfNotExists();
             Usuario usuario = new Usuario() {Nome = "xx", Senha = "xxx" };
             contexto.Usuarios.Add(usuario);
             contexto.SaveChanges();
             contexto.Dispose();

             Console.WriteLine("fecho");
             Console.ReadLine();*/
            /* CategoriaDoProduto c = new CategoriaDoProduto()
             {
                 Nome = "informatica"
             };
             Produto p = new Produto()
             {
                 Nome = "computador",
                 Categoria = c,
                 Preco = 1000
             };*/
            ////////////////////Exemplo 2
            /*   Produto p = new Produto()
               {
                   Nome = "impressora",
                   Preco = 200,
                   CategoriaID = 1
               };

          //     contexto.Categorias.Add(c);
               contexto.Produtos.Add(p);
               contexto.SaveChanges();*/

            CategoriaDoProduto categoria = contexto.Categorias.Find(1);
            foreach(var produto in categoria.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }
            contexto.Dispose();
            Console.WriteLine("Gravado");
            Console.Read();







        }
    }
}
