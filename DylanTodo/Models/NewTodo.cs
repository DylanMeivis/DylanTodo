using System;
using System.ComponentModel.DataAnnotations;

namespace DylanTodo.Models
{
    public class NewTodo
    {
        [Required]
        public string Description {get; set;}
        public Guid Id { get; set;}
        public NewTodo()
        {

        }
    }
}
