
namespace Connector.One
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Interfaces.Models;
    using Interfaces;
    using Services;

    public class ConnectorOne : ITodoConnector
    {
        private readonly IMyService _service;

        public ConnectorOne(IMyService service)
        {
            _service = service;
        }

        public Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return Task.FromResult((IEnumerable<TodoItem>)null);
        }

        public Task<TodoItem> GetByIdAsync(Guid id)
        {
            return _service.GetByIdAsync(id);
        }
    }
}
