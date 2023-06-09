﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        // Data Annotations
        [Required] // Not Null
        [MaxLength(250)] // varchar(250)
        public string Name { get; set; }
        [MaxLength(10)]
        public string AddressNo { get; set; }
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string JobRole { get; set; }
        public ICollection<Todo> Todos { get; set; } = new List<Todo>(); // no null values comes
        // when it starts, its create a default List
        // it will nerver return null values
    }
}
