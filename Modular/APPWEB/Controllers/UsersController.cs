using APPWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using API.Data;

namespace APPWEB.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDBContext _context;

        public UsersController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersViewModel = await _context.Users.FirstOrDefaultAsync(m => m.Id_Users == id);

            if (usersViewModel == null)
            {
                return NotFound();
            }

            return View(usersViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Users,N_Identification,TypeDocument,FirstName,LastName,UserEmail,Username,UserPassword,Status,UserType")] UsersViewModel usersViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usersViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("","Error!");
            }

            return View(usersViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersViewModel = await _context.Users.FindAsync(id);
            if (usersViewModel == null)
            {
                return NotFound();
            }
            return View(usersViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Users,N_Identification,TypeDocument,FirstName,LastName,UserEmail,Username,UserPassword,Status,UserType")] UsersViewModel usersViewModel)
        {
            if (id != usersViewModel.Id_Users)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersViewModelExists(usersViewModel.Id_Users))
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
            return View(usersViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersViewModel = await _context.Users
                .FirstOrDefaultAsync(m => m.Id_Users == id);
            if (usersViewModel == null)
            {
                return NotFound();
            }

            return View(usersViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersViewModel = await _context.Users.FindAsync(id);
            _context.Users.Remove(usersViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersViewModelExists(int id)
        {
            return _context.Users.Any(e => e.Id_Users == id);
        }

    }
}