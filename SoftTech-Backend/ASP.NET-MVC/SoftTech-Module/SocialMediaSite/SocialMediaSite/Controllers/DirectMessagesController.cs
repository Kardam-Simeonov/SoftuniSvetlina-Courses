using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialMediaSite.Data.Models;

namespace SocialMediaSite.Controllers
{
    public class DirectMessagesController : Controller
    {
        private readonly SocialMediaContext _context;

        public DirectMessagesController(SocialMediaContext context)
        {
            _context = context;
        }

        // GET: DirectMessages
        public async Task<IActionResult> Index()
        {
              return _context.DirectMessages != null ? 
                          View(await _context.DirectMessages.ToListAsync()) :
                          Problem("Entity set 'SocialMediaContext.DirectMessages'  is null.");
        }

        // GET: DirectMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DirectMessages == null)
            {
                return NotFound();
            }

            var directMessage = await _context.DirectMessages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directMessage == null)
            {
                return NotFound();
            }

            return View(directMessage);
        }

        // GET: DirectMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DirectMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Message,SenderName,RecieverName,TimeStamp")] DirectMessage directMessage)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(x => x.Username == directMessage.SenderName) && _context.Users.Any(x => x.Username == directMessage.RecieverName))
                {
                    directMessage.TimeStamp = DateTime.Now;

                    _context.Add(directMessage);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(directMessage);
        }

        // GET: DirectMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DirectMessages == null)
            {
                return NotFound();
            }

            var directMessage = await _context.DirectMessages.FindAsync(id);
            if (directMessage == null)
            {
                return NotFound();
            }
            return View(directMessage);
        }

        // POST: DirectMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Message,SenderName,RecieverName,TimeStamp")] DirectMessage directMessage)
        {
            if (id != directMessage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(directMessage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DirectMessageExists(directMessage.Id))
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
            return View(directMessage);
        }

        // GET: DirectMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DirectMessages == null)
            {
                return NotFound();
            }

            var directMessage = await _context.DirectMessages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directMessage == null)
            {
                return NotFound();
            }

            return View(directMessage);
        }

        // POST: DirectMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DirectMessages == null)
            {
                return Problem("Entity set 'SocialMediaContext.DirectMessages'  is null.");
            }
            var directMessage = await _context.DirectMessages.FindAsync(id);
            if (directMessage != null)
            {
                _context.DirectMessages.Remove(directMessage);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DirectMessageExists(int id)
        {
          return (_context.DirectMessages?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
