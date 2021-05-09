using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model_2_test.Data;
using Model_2_test.Models;

namespace Model_2_test.Controllers
{
    public class StudentEnrollmentsController : Controller
    {
        private readonly StudentContext _context;

        public StudentEnrollmentsController(StudentContext context)
        {
            _context = context;
        }

        // GET: StudentEnrollments
        public async Task<IActionResult> Index()
        {
            var studentContext = _context.StudentEnrollment.Include(s => s.Major).Include(s => s.Student);
            return View(await studentContext.ToListAsync());
        }

        // GET: StudentEnrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentEnrollment = await _context.StudentEnrollment
                .Include(s => s.Major)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (studentEnrollment == null)
            {
                return NotFound();
            }

            return View(studentEnrollment);
        }

        // GET: StudentEnrollments/Create
        public IActionResult Create()
        {
            ViewData["MajorID"] = new SelectList(_context.Major, "MajorID", "MajorID");
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID");
            return View();
        }

        // POST: StudentEnrollments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollmentID,MajorID,StudentID")] StudentEnrollment studentEnrollment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentEnrollment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MajorID"] = new SelectList(_context.Major, "MajorID", "MajorID", studentEnrollment.MajorID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID", studentEnrollment.StudentID);
            return View(studentEnrollment);
        }

        // GET: StudentEnrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentEnrollment = await _context.StudentEnrollment.FindAsync(id);
            if (studentEnrollment == null)
            {
                return NotFound();
            }
            ViewData["MajorID"] = new SelectList(_context.Major, "MajorID", "MajorID", studentEnrollment.MajorID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID", studentEnrollment.StudentID);
            return View(studentEnrollment);
        }

        // POST: StudentEnrollments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnrollmentID,MajorID,StudentID")] StudentEnrollment studentEnrollment)
        {
            if (id != studentEnrollment.EnrollmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentEnrollment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentEnrollmentExists(studentEnrollment.EnrollmentID))
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
            ViewData["MajorID"] = new SelectList(_context.Major, "MajorID", "MajorID", studentEnrollment.MajorID);
            ViewData["StudentID"] = new SelectList(_context.Student, "ID", "ID", studentEnrollment.StudentID);
            return View(studentEnrollment);
        }

        // GET: StudentEnrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentEnrollment = await _context.StudentEnrollment
                .Include(s => s.Major)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.EnrollmentID == id);
            if (studentEnrollment == null)
            {
                return NotFound();
            }

            return View(studentEnrollment);
        }

        // POST: StudentEnrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentEnrollment = await _context.StudentEnrollment.FindAsync(id);
            _context.StudentEnrollment.Remove(studentEnrollment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentEnrollmentExists(int id)
        {
            return _context.StudentEnrollment.Any(e => e.EnrollmentID == id);
        }
    }
}
