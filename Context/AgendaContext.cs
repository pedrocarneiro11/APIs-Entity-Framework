using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_Introducao_a_APIs_com_Csharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace _10_Introducao_a_APIs_com_Csharp.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}