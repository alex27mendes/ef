using EF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class EntidadeContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaDoProduto> Categorias { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<CategoriaDoProduto> configuracao = modelBuilder.Entity<CategoriaDoProduto>();
            configuracao.HasMany(categoria => categoria.Produtos)
                .WithOptional(produto => produto.Categoria);
        }
    }
}
