using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories.IRepository {
    public interface IClientRepository {
        void CreateClient(Client client);
        IEnumerable<Client> GetAll();
        Client GetById(int? id);
        void UpdateClient(Client client);
        void DeleteClient(Client client);
    }
}
