using AccountManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using AccountManagement.Models.Interfaces;

namespace AccountManagement.Api.Controllers
{
    /// <summary>
    /// This controller manages access to the customers in the system allowing a list of current customers to be retrieved
    /// </summary>
    public class CustomersController : ApiController
    {
        ICustomerService _customerService;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customerService"></param>
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customers
        /// <summary>
        /// This returns a list of all customers currently in the system
        /// </summary>
        /// <returns></returns>
        public List<ICustomer> Get()
        {
            return _customerService.GetCustomers();
        }

        // GET: api/Customers/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ICustomer Get(Guid id)
        {
            return _customerService.GetCustomers().Where(x => x.CustomerID == id).SingleOrDefault();
        }

        // POST: api/Customers
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Customers/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Customers/5
        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
