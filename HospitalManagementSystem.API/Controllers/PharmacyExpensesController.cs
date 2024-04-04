﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.API.Data;
using HospitalManagementSystem.API.Models;

namespace HospitalManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyExpensesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public PharmacyExpensesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/PharmacyExpenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PharmacyExpense>>> GetPharmacyExpenses()
        {
            return await _context.PharmacyExpenses.ToListAsync();
        }

        // GET: api/PharmacyExpenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PharmacyExpense>> GetPharmacyExpense(int id)
        {
            var pharmacyExpense = await _context.PharmacyExpenses.FindAsync(id);

            if (pharmacyExpense == null)
            {
                return NotFound();
            }

            return pharmacyExpense;
        }

        // PUT: api/PharmacyExpenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPharmacyExpense(int id, PharmacyExpense pharmacyExpense)
        {
            if (id != pharmacyExpense.Id)
            {
                return BadRequest();
            }

            _context.Entry(pharmacyExpense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PharmacyExpenseExists(id))
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

        // POST: api/PharmacyExpenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PharmacyExpense>> PostPharmacyExpense(PharmacyExpense pharmacyExpense)
        {
            _context.PharmacyExpenses.Add(pharmacyExpense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPharmacyExpense", new { id = pharmacyExpense.Id }, pharmacyExpense);
        }

        // DELETE: api/PharmacyExpenses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePharmacyExpense(int id)
        {
            var pharmacyExpense = await _context.PharmacyExpenses.FindAsync(id);
            if (pharmacyExpense == null)
            {
                return NotFound();
            }

            _context.PharmacyExpenses.Remove(pharmacyExpense);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PharmacyExpenseExists(int id)
        {
            return _context.PharmacyExpenses.Any(e => e.Id == id);
        }
    }
}
