namespace Front.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System;
    using Connector.Interfaces;

    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {
        private readonly ITodoConnector _connector;

        public TodoItemsController(ITodoConnector connector)
        {
            _connector = connector;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await _connector.GetAllAsync();
            if (items == null)
                return NoContent();

            return Ok(items);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await _connector.GetByIdAsync(id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }
    }
}
