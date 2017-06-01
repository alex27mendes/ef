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
            CategoriaDoProduto c = new CategoriaDoProduto()
            {
                Nome = "informatica"
            };
            Produto p = new Produto()
            {
                Nome = "computador",
                Categoria = c,
                Preco = 1000
            };
            contexto.Categorias.Add(c);
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
            contexto.Dispose();
            Console.WriteLine("Gravado");
            Console.Read();


     
             
        }
    }
}
