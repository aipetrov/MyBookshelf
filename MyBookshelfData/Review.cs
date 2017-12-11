using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookshelfData
{
    public class Review
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Book Book { get; set; }

        public int Rating { get; set; }

        public DateTime DateTime { get; set; }

        public string Comment { get; set; }
    }
}
