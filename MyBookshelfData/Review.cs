﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookshelfData
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
