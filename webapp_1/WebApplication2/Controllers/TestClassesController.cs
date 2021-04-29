using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestClassesController : ControllerBase
    {
        private readonly TestContext _context;

        public TestClassesController(TestContext context)
        {
            _context = context;
        }

        // GET: api/TestClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestClass>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TestClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestClass>> GetTestClass(long id)
        {
            var testClass = await _context.TodoItems.FindAsync(id);

            if (testClass == null)
            {
                return NotFound();
            }

            return testClass;
        }

        // PUT: api/TestClasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestClass(long id, TestClass testClass)
        {
            if (id != testClass.Id)
            {
                return BadRequest();
            }

            _context.Entry(testClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestClassExists(id))
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

        // POST: api/TestClasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestClass>> PostTestClass(TestClass testClass)
        {
            _context.TodoItems.Add(testClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTestClass), new { id = testClass.Id }, testClass);
        }

        // DELETE: api/TestClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestClass(long id)
        {
            var testClass = await _context.TodoItems.FindAsync(id);
            if (testClass == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(testClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestClassExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
