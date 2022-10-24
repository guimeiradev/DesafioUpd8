using CadastroCliente.Models;
using CadastroCliente.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroCliente.Controllers {

    public class ClientController : Controller {

        private readonly IClientRepository _repository;

        public ClientController(IClientRepository repository) {

            _repository = repository;
        }

       
        [HttpGet]
        public IActionResult Index() {

            return View(_repository.GetAll());

        }


        [HttpGet]
        public IActionResult CreateClient() {

            return View();

        }

        [HttpPost]
        public IActionResult CreateClient(Client client) {

            if (ModelState.IsValid) {

                _repository.CreateClient(client);

                return RedirectToAction(nameof(Index));
            }
            else {

                return View(client);

            }

        }

        [HttpGet]
        public IActionResult UpdateClient(int? id) {
            if (id != null) {

                Client client = _repository.GetById(id);


                return View(client);


            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult UpdateClient(int? id,Client client) {
            if(id != null) {
                _repository.UpdateClient(client);
                return RedirectToAction(nameof(Index));

            }
            else {
                return View(client);
            }
        }

        [HttpGet]
        public IActionResult DeleteClient(int? id) {
            if (id != null) {

                Client client = _repository.GetById(id);


                return View(client);


            } else {
                return NotFound();
            }
        }




        [HttpPost]
        public IActionResult DeleteClient(int? id,Client client) {

            if (id != null) {
                _repository.DeleteClient(client);
                return RedirectToAction(nameof(Index));

            } else {
                return View(client);
            }
        }
    }
}
