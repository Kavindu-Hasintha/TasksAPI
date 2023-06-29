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
        public List<Todo> GetAllTodos(int authorId)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
            //return _context.Todos.ToList();
            // ToList() coming from System.Linq
        }

        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authorId);
        }

        public Todo AddTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return _context.Todos.Find(todo.Id);
        }

        public void UpdateTodo(Todo todo)
        {
            _context.SaveChanges(); // It will update automatically
        }

        public void DeleteTodo(Todo todo)
        {
            _context.Remove(todo);
            _context.SaveChanges();
        }
    }
}
