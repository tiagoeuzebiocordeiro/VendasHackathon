using Microsoft.AspNetCore.Mvc;
using VendasHackathon.Models;
using VendasHackathon.Repositories.Venda;

namespace VendasHackathon.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaController(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IActionResult Index()
        {
            var vendas = _vendaRepository.GetAll();
            return View(vendas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VendaModel venda)
        {
            if (venda == null)
            {
                return NotFound();
            }
            _vendaRepository.Add(venda);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == null || id == 0) {
                return NotFound();
            }
            VendaModel venda = _vendaRepository.GetById(id);
            return View(venda);
        }

        [HttpPost]
        public IActionResult Update(VendaModel venda)
        {
            if (ModelState.IsValid)
            {
                _vendaRepository.Update(venda);
                return RedirectToAction("Index");
            }
            return View(venda);
        }

    }
}
