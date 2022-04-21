using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ivanov_ASP.NET_04.Data;
using Ivanov_ASP.NET_04.Models;
using Ivanov_ASP.NET_04.ViewModels;
using System.Text.Json;

namespace Ivanov_ASP.NET_04.Controllers
{
    public class ActorsController : Controller
    {
        private readonly Ivanov_MovieCatalogContext _context;

        public ActorsController(Ivanov_MovieCatalogContext context)
        {
            _context = context;
        }

        // GET: Actors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actors.ToListAsync());
        }

        // GET: Actors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors
                .FirstOrDefaultAsync(m => m.ActorId == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActorId,Name,Age,Birthdate,ACountry,Photo")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: Actors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        // POST: Actors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActorId,Name,Age,Birthdate,ACountry,Photo")] Actor actor)
        {
            if (id != actor.ActorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorExists(actor.ActorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: Actors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actors
                .FirstOrDefaultAsync(m => m.ActorId == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _context.Actors.FindAsync(id);
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActorExists(int id)
        {
            return _context.Actors.Any(e => e.ActorId == id);
        }

        //JQueryAjax
        public ActionResult JQueryAjax()
        {
            var viewModel = new ActorsViewModel
            {
                Actors = _context.Actors.ToList(),
                Countries = new List<Country>
                {
                    new Country {Id = 1, Name = "Australia" },
                    new Country {Id = 2, Name = "England" },
                    new Country {Id = 3, Name = "USA" },
                    new Country {Id = 4, Name = "Romania" },
                    new Country {Id = 5, Name = "Canada" },
                    new Country {Id = 6, Name = "Denmark" },
                    new Country {Id = 7, Name = "Wales" },
                    new Country {Id = 8, Name = "China" },
                    new Country {Id = 9, Name = "Mexico" }
                }
            };

            return View("JQueryAjaxForm", viewModel);
        }

        //метод вызывается из Ajax.Html и возвращает JSON, который содержит коллекцию результатов 
        [HttpPost]
        public JsonResult ActorsListJson([FromBody] object body)
        {
            var dict = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(body.ToString());
            string country = dict["country"];

            IEnumerable<Actor> filteredActors = null;

            if (country != null)
                filteredActors = from p in _context.Actors.ToList()
                                 where p.ACountry.Equals(country)
                                 select p;
            else
                filteredActors = from p in _context.Actors.ToList()
                                 select p;

            // преобразовать результирующую коллекцию в формат Json и возвратить
            var result = Json(filteredActors, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null
            });

            return result;
        }
    }
}
