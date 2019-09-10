using System;
using System.Collections.Generic;
namespace DylanTodo.Models
{
    public class TodoList
    {
        public List<TodoItem> AllItems = new List<TodoItem>();
        public TodoList()
        {
            var item = new TodoItem("Hello");
            var item2 = new TodoItem("Yello");
            AllItems.Add(item);
            AllItems.Add(item2);
        }
    }
}
