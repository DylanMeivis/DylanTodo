using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DylanTodo.Models
{
    public class TodoList
    {
        public TodoUser User { get; set; }
        public List<TodoItem> AllItems = new List<TodoItem>();
        [Required]
        public NewTodo newTodo { get; set; }
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
        public static TodoList ReturnTodoList(string _jsonString)
        {
            var _todoList = Newtonsoft.Json.JsonConvert.DeserializeObject<TodoList>(_jsonString);
            return _todoList;
        }
        public static string AddTodoItem(string _jsonString, TodoItem newTodo)
        {
            var _todoList = Newtonsoft.Json.JsonConvert.DeserializeObject<TodoList>(_jsonString);
            _todoList.AllItems.Add(newTodo);
            return Newtonsoft.Json.JsonConvert.SerializeObject(_todoList);
        }

        public static string UpdateTodo(string _jsonString, TodoItem updatedTodo)
        {
            var id = updatedTodo.Id;
            var _todoList = Newtonsoft.Json.JsonConvert.DeserializeObject<TodoList>(_jsonString);

            TodoItem result = _todoList.AllItems.Where( x => x.Id == id ).FirstOrDefault();
            result.Description = updatedTodo.Description;

            return Newtonsoft.Json.JsonConvert.SerializeObject(_todoList);
        }
    }
}
