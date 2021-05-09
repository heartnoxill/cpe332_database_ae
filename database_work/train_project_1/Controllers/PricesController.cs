using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using train_project_1.Data;
using train_project_1.Models;

namespace train_project_1.Controllers
{
    public class PricesController : Controller
    {
        private readonly TrainContext _context;

        public PricesController(TrainContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Index()
        {
            var trainContext = _context.Prices.Include(p => p.Class).Include(p => p.Promotion).Include(p => p.Route);
            return View(await trainContext.ToListAsync());
        }

        // GET: Prices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices
                .Include(p => p.Class)
                .Include(p => p.Promotion)
                .Include(p => p.Route)
                .FirstOrDefaultAsync(m => m.TicketT_id == id);
            if (price == null)
            {
                return NotFound();
            }

            return View(price);
        }

        // GET: Prices/Create
        public IActionResult Create()
        {
            ViewData["ClassC_id"] = new SelectList(_context.Class, "C_id", "C_id");
            ViewData["PromotionPromotion_id"] = new SelectList(_context.Promotions, "Promotion_id", "Promotion_id");
            ViewData["RouteR_id"] = new SelectList(_context.Routes, "R_id", "R_id");
            return View();
        }

        // POST: Prices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TotalPrice,TicketT_id,ClassC_id,PromotionPromotion_id,RouteR_id")] Price price)
        {
            if (ModelState.IsValid)
            {
                _context.Add(price);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassC_id"] = new SelectList(_context.Class, "C_id", "C_id", price.ClassC_id);
            ViewData["PromotionPromotion_id"] = new SelectList(_context.Promotions, "Promotion_id", "Promotion_id", price.PromotionPromotion_id);
            ViewData["RouteR_id"] = new SelectList(_context.Routes, "R_id", "R_id", price.RouteR_id);
            return View(price);
        }

        // GET: Prices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices.FindAsync(id);
            if (price == null)
            {
                return NotFound();
            }
            ViewData["ClassC_id"] = new SelectList(_context.Class, "C_id", "C_id", price.ClassC_id);
            ViewData["PromotionPromotion_id"] = new SelectList(_context.Promotions, "Promotion_id", "Promotion_id", price.PromotionPromotion_id);
            ViewData["RouteR_id"] = new SelectList(_context.Routes, "R_id", "R_id", price.RouteR_id);
            return View(price);
        }

        // POST: Prices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TotalPrice,TicketT_id,ClassC_id,PromotionPromotion_id,RouteR_id")] Price price)
        {
            if (id != price.TicketT_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(price);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriceExists(price.TicketT_id))
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
            ViewData["ClassC_id"] = new SelectList(_context.Class, "C_id", "C_id", price.ClassC_id);
            ViewData["PromotionPromotion_id"] = new SelectList(_context.Promotions, "Promotion_id", "Promotion_id", price.PromotionPromotion_id);
            ViewData["RouteR_id"] = new SelectList(_context.Routes, "R_id", "R_id", price.RouteR_id);
            return View(price);
        }

        // GET: Prices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var price = await _context.Prices
                .Include(p => p.Class)
                .Include(p => p.Promotion)
                .Include(p => p.Route)
                .FirstOrDefaultAsync(m => m.TicketT_id == id);
            if (price == null)
            {
                return NotFound();
            }

            return View(price);
        }

        // POST: Prices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var price = await _context.Prices.FindAsync(id);
            _context.Prices.Remove(price);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PriceExists(int id)
        {
            return _context.Prices.Any(e => e.TicketT_id == id);
        }
    }
}
