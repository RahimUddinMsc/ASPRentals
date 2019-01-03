using AspRentals.Dtos;
using AspRentals.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspRentals.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/<controller>
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers.Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));

            var customerDto = customersQuery.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDto);
        }

        // GET api/<controller>/5        
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();  

            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id.ToString()),customerDto);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void IHttpActionResult (int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                BadRequest();

            var customeInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customeInDb == null)
                NotFound();

            Mapper.Map(customerDto, customeInDb);
            
            _context.SaveChanges();          
        }

        // DELETE api/<controller>/
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

        }
    }
}
