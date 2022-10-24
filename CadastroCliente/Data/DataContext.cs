using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Data {
    public class DataContext : DbContext {
        public DbSet<Client> Clients { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
           : base(options) {
        }

    }
}
