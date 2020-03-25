using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class State
    {
        public List<ToDoItem> ToDos { get; set; } = new List<ToDoItem>();
    }
}
