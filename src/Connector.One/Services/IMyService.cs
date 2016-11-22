using System;
using System.Threading.Tasks;
using Connector.Interfaces.Models;

namespace Connector.One.Services
{
    public interface IMyService
    {
        Task<TodoItem> GetByIdAsync(Guid id);
    }
}
