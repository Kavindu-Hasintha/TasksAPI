using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            // return _context.Authors.Where(a => a.Id == id).FirstOrDefault();
            return _context.Authors.Find(id);
        }

        public List<Author> GetAllAuthors(string job, string search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search))
            {
                return GetAllAuthors();
            }

            var authorCollection = _context.Authors as IQueryable<Author>;
            // First, we make the query
            // SQL Command will create using this IQueryable
            // Type - Author

            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(a => a.JobRole == job);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => a.Name.Contains(search) || a.City.Contains(search));
            }

            return authorCollection.ToList();
        }

        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges(); // Save the data in the DB

            return _context.Authors.Find(author.Id);
        }
    }
}
