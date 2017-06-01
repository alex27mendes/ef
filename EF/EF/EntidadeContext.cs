﻿using EF.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}