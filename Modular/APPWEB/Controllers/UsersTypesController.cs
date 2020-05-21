using API.Data;
using Bussiness_Logic.Models;
using Consult_API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace APPWEB.Controllers
{
    public class UsersTypesController : Controller
    {
        private readonly AppDBContext _context;

        public UsersTypesController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<UsersType> UsersType = null;

            Consult_API.ConsultAPI consultAPI = new ConsultAPI();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57764");
                
                var responseTask = client.GetAsync("API/UsersTypes");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    string customersString = await result.Content.ReadAsStringAsync();
                    UsersType = JsonConvert.DeserializeObject<List<UsersType>>(customersString);
                }
                else
                {                    
                    UsersType = Enumerable.Empty<UsersType>();
                    ModelState.AddModelError(string.Empty, "Server Error...");
                }
            }

            return View(UsersType);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersType = await _context.UsersType
                .FirstOrDefaultAsync(m => m.Id_UsersType == id);

            if (usersType == null)
            {
                return NotFound();
            }

            return View(usersType);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_UsersType,UsersTypeName")] UsersType usersType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersType);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersType = await _context.UsersType.FindAsync(id);
            if (usersType == null)
            {
                return NotFound();
            }
            return View(usersType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_UsersType,UsersTypeName")] UsersType usersType)
        {
            if (id != usersType.Id_UsersType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersTypeExists(usersType.Id_UsersType))
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
            return View(usersType);
        }

        // GET: UsersTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersType = await _context.UsersType
                .FirstOrDefaultAsync(m => m.Id_UsersType == id);
            if (usersType == null)
            {
                return NotFound();
            }

            return View(usersType);
        }

        // POST: UsersTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersType = await _context.UsersType.FindAsync(id);
            _context.UsersType.Remove(usersType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersTypeExists(int id)
        {
            return _context.UsersType.Any(e => e.Id_UsersType == id);
        }
    }
}
