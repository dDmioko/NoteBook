﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.Data.Models
{
    public class School : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}