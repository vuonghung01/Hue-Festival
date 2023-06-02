using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hue_Festival;
using Hue_Festival.Models;

namespace Hue_Festival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportMenusController : ControllerBase
    {
        private readonly HueFestivalContext _context;

        public SupportMenusController(HueFestivalContext context)
        {
            _context = context;
        }

        // GET: api/SupportMenus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportMenu>>> GetSupportMenus()
        {
          if (_context.SupportMenus == null)
          {
              return NotFound();
          }
            return await _context.SupportMenus.ToListAsync();
        }

        // GET: api/SupportMenus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportMenu>> GetSupportMenu(int id)
        {
          if (_context.SupportMenus == null)
          {
              return NotFound();
          }
            var supportMenu = await _context.SupportMenus.FindAsync(id);

            if (supportMenu == null)
            {
                return NotFound();
            }

            return supportMenu;
        }

        // PUT: api/SupportMenus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportMenu(int id, SupportMenu supportMenu)
        {
            if (id != supportMenu.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportMenuExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SupportMenus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportMenu>> PostSupportMenu(SupportMenu supportMenu)
        {
          if (_context.SupportMenus == null)
          {
              return Problem("Entity set 'HueFestivalContext.SupportMenus'  is null.");
          }
            _context.SupportMenus.Add(supportMenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupportMenu", new { id = supportMenu.Id }, supportMenu);
        }

        // DELETE: api/SupportMenus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportMenu(int id)
        {
            if (_context.SupportMenus == null)
            {
                return NotFound();
            }
            var supportMenu = await _context.SupportMenus.FindAsync(id);
            if (supportMenu == null)
            {
                return NotFound();
            }

            _context.SupportMenus.Remove(supportMenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportMenuExists(int id)
        {
            return (_context.SupportMenus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
