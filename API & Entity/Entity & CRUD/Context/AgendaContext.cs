using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity___CRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity___CRUD.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }

    }
}