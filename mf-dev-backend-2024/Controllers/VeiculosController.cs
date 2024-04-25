using mf_dev_backend_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2024.Controllers
{
    public class VeiculosController : Controller //herar 
    {
        private readonly AppDbContext _context;
        public VeiculosController(AppDbContext context)
        {
            _context = context;       
        }
        
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            if(ModelState.IsValid)
            {
                _context.Veiculos.Add(veiculo); //add o veiculos
                await _context.SaveChangesAsync(); // salvar o veiculo
                return RedirectToAction("Index"); //retornar a tela de index
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id) //id da rota do item 
                                                       //? = pode ser nulo/vem branco
        {
            if (id == null)
                return NotFound(); //404 - não encontardo 

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Veiculo veiculo)
        {
            if (id != veiculo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Veiculos.Update(veiculo); // Update na lista 
                await _context.SaveChangesAsync(); // salvar a alteração no BD
                return RedirectToAction("Index"); //retornar a tela de index
            }
            return View();
        }

        public async Task<IActionResult> Details (int? id)
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();
            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();
            return View(dados);
        }

        [HttpPost, ActionName ("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Veiculos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
