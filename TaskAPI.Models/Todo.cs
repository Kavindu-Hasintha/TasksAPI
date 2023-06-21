namespace TaskAPI.Models
{
    // To represent  one raw in Todo table in the Database
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public TodoStatus Status { get; set; }
        // Usually, use an enum for status values.

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
