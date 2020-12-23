using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NoteBook.Data.Models;

namespace NoteBook.Data
{
    public class NoteBookDbContext : DbContext
    {
        public NoteBookDbContext() { }
        public NoteBookDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<School> Schools { get; set; }
    }
}
