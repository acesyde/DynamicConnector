using System;
using System.Threading.Tasks;
using Connector.Interfaces.Models;

namespace Connector.One.Services
{
    public class MyService : IMyService
    {
        public Task<TodoItem> GetByIdAsync(Guid id)
        {
            return Task.FromResult(new TodoItem
            {
                Id = id,
                Title = "test",
                Content = "test content"
            });
        }
    }
}
