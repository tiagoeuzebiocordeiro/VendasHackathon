using Microsoft.AspNetCore.Mvc;
using VendasHackathon.Models;
using VendasHackathon.Repositories.ItemVenda;

namespace VendasHackathon.Controllers
{
    public class ItemVendaController : Controller
    {
        private readonly IItemVendaRepository _itemVendaRepository;
        public ItemVendaController(IItemVendaRepository itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }
        public IActionResult Index()
        {
            var itens = _itemVendaRepository.GetAll();
            return View(itens);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemVendaModel model)
        {
            if (model == null)
            {
                return NotFound();
            }
            _itemVendaRepository.Add(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            ItemVendaModel itemVenda = _itemVendaRepository.GetById(id);
            return View(itemVenda);
        }

        [HttpPost]
        public IActionResult Update(ItemVendaModel itemVenda)
        {
            if (ModelState.IsValid)
            {
                _itemVendaRepository.Update(itemVenda);
                return RedirectToAction("Index");
            }
            return View(itemVenda);
        }

    }
}
