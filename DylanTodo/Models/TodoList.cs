using System;
using System.Collections.Generic;
namespace DylanTodo.Models
{
    public class TodoList
    {
        public TodoUser User{ get; set; }
        public List<TodoItem> AllItems = new List<TodoItem>();
        public TodoList(TodoUser user)
        {
            var item = new TodoItem("Hello");
            var item2 = new TodoItem("Yello");
            AllItems.Add(item);
            AllItems.Add(item2);
            User = user;
        }
    }
}
