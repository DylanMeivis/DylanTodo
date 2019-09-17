using System;
using Newtonsoft.Json;

namespace DylanTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        [JsonConstructor]
        public TodoItem(string desc)
        {
            Description = desc;
            Id = Guid.NewGuid();
            IsCompleted = false;
        }
        public TodoItem(string desc, Guid id)
        {
            Description = desc;
            Id = id;
            IsCompleted = false;
        }
    }
}
