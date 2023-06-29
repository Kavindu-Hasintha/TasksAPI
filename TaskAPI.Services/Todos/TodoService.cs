using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Test1",
                Description = "Test Description 1",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Test2",
                Description = "Test Description 2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(10),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo2);
            // return todos;
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Test3",
                Description = "Test Description 3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(15),
                Status = TodoStatus.Complete
            };
            todos.Add(todo3);

            return todos;
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllTodos(int authorId)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
