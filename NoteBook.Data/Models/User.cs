using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.Data.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual School School { get; set; }
    }
}
