using System;
using System.ComponentModel.DataAnnotations;

namespace DylanTodo.Models
{
    public class TodoUser
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        protected int AmountCompleted { get; set; }

        public TodoUser()
        {
            AmountCompleted = 0;
        }

        //Method to increase the amount of todos completed.
        public void IncrementCompleted()
        {
            AmountCompleted += 1;
        }
    }
}
