﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NutriView.Server.Data;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

namespace NutriView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {

          var customers = await _unitofWork.Customers.GetAll();
          return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(int id)
        {

            var customer = await _unitofWork.Customers.Get(q=>q.Id==id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(customer).State = EntityState.Modified;
            _unitofWork.Customers.Update(customer);
            try
            {
                await _unitofWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
          //if (_context.Customers == null)
          //{
          //    return Problem("Entity set 'ApplicationDbContext.Customers'  is null.");
          //}
          //  _context.Customers.Add(customer);
          //  await _context.SaveChangesAsync();

            await _unitofWork.Customers.Insert(customer);
            await _unitofWork.Save(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            //if (_context.Customers == null)
            //{
            //    return NotFound();
            //}
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);
            //if (customer == null)
            //{
            //    return NotFound();
            //}

            //_context.Customers.Remove(customer);
            //await _context.SaveChangesAsync();

            await _unitofWork.Customers.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            //return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
            var customer =await _unitofWork.Customers.Get(q=>q.Id== id);
            return customer != null;
        }
    }
}
