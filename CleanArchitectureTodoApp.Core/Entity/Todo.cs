using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureTodoApp.Core.Entity
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Todo(int id, string title, bool completed)
        {
            Id = id;
            Title = title;
            Completed = completed;
        }
    }
}
