namespace Connector.Interfaces
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITodoConnector
    {
        Task<TodoItem> GetByIdAsync(Guid id);
        Task<IEnumerable<TodoItem>> GetAllAsync();
    }
}
