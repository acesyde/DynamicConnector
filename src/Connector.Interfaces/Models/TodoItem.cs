namespace Connector.Interfaces.Models
{
    using System;

    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
