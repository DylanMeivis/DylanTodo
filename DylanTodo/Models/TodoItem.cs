using System;
namespace DylanTodo.Models
{
    public class TodoItem
    {
        private Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TodoItem(string desc)
        {
            Description = desc;
            Id = Guid.NewGuid();
            IsCompleted = false;
        }
    }
}
