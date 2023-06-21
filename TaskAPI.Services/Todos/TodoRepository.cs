using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> GetAllTodos()
        {
            return _context.Todos.ToList();
            // ToList() coming from System.Linq
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
