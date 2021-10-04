using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Trabalho.Models;

namespace Trabalho.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Trabalho") { }

        public DbSet<Aluno> aluno { get; set; }
    }
}