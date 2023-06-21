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
    }
}
