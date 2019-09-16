using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DylanTodo.Models
{
    public class TodoList
    {
        public TodoUser User{ get; set; }
        public List<TodoItem> AllItems = new List<TodoItem>();
        [Required]
        public string newTodo {get; set;}
        public TodoList(TodoUser user)
        {
            var item = new TodoItem("Hello");
            var item2 = new TodoItem("Yello");
            AllItems.Add(item);
            AllItems.Add(item2);
            User = user;
        }
        public TodoList()
        {

        }
    }
}
