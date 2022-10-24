using CadastroCliente.Data;
using CadastroCliente.Models;
using CadastroCliente.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories {
    public class ClientRepository : IClientRepository {

        private readonly DataContext _context;

        public ClientRepository(DataContext context) {
            _context = context;
        }

        public void CreateClient(Client client) {

            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAll() {

            return _context.Clients
                .AsNoTracking()
                .OrderByDescending(x => x.Id)
                .ToList();


        }

        public Client GetById(int? id) {

            return _context.Clients
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

        }

        public void UpdateClient(Client client) {

            _context.Update(client);
            _context.SaveChanges();
        }

        public void DeleteClient(Client client) {

            _context.Remove(client);
            _context.SaveChanges();
        }
    }
}
