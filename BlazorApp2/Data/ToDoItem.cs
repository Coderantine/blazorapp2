using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Data
{
    public class ToDoItem
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
