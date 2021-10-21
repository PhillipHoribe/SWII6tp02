using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationTp02.Models;

namespace WebApplicationTp02.DAO
{
    public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaDoProduto> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}