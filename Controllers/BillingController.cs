using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuildableNetAPI.Controllers
{
    [ApiController]
    [Route("/billing/v1")]
    public class BillingController : ControllerBase
    {

        private readonly ILogger<BillingController> _logger;

        public BillingController(ILogger<BillingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{customerId}")]
        public CustomerBill Get(int customerId)
        {
            return new CustomerBill
            {
                CustomerId = customerId,
                DueDate = DateTime.Now.AddDays(30),
                Cost = 35.56M
            };
        }
    }
}