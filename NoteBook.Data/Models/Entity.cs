using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.Data.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
