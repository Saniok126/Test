using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Route("api")]
    [ApiController]
    public class MainController : ControllerBase
    {
        public MyService _myService;
        public MainController(MyService myService)
        {
            _myService = myService;
        }
        /// <summary>
        ///  Get items list
        /// </summary>
        /// <response code="200">Application list sent</response>
        /// <response code="400">Handle some error</response>        
        /// <response code="403">Forbid for current role</response>
        [HttpGet]
        [Route("items_list")]
        public IActionResult GetItemsList()
        {
            var items = _myService.GetItems();
            return Ok(items);
        }

        /// <summary>
        ///  Get orders list
        /// </summary>
        /// <response code="200">Application list sent</response>
        /// <response code="400">Handle some error</response>        
        /// <response code="403">Forbid for current role</response>
        [HttpGet]
        [Route("orders_list")]
        public IActionResult GetOrdersList()
        {
            var items = _myService.GetOrders();
            return Ok(items);
        }

        /// <summary>
        ///  Create new order
        /// </summary>
        /// <response code="200">Application list sent</response>
        /// <response code="400">Handle some error</response>        
        /// <response code="403">Forbid for current role</response>
        [HttpPost]
        [Route("order")]
        public IActionResult NewOrder(NewOrderViewModel model)
        {
            if (ModelState.IsValid)
            {

                return Ok();
            }
            return BadRequest();
         
        }
    }
}
