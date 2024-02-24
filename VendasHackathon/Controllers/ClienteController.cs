using Microsoft.AspNetCore.Mvc;
using VendasHackathon.Models;
using VendasHackathon.Repositories.Cliente;

namespace VendasHackathon.Controllers
{
    public class ClienteController : Controller
    {
        // Por que injeto a interface e nao o repository? pois estou trabalhando com Repository Pattern, e, toda vez que eu me referir a essa Interface, estarei me referindo ao Repository class, pois defini isso no program.cs (addScoped)
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult Index()
        {
            var clientes = _clienteRepository.GetAll();
            return View(clientes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClienteModel cliente) 
        {
            if (cliente == null)
            {
                return NotFound();
            }
            _clienteRepository.Add(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ClienteModel cliente = _clienteRepository.GetById(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Update(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Update(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        public IActionResult InativaCliente(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            ClienteModel cliente = _clienteRepository.GetById(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult InativaCliente(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.InativaCliente(cliente.Id);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

    }
}
