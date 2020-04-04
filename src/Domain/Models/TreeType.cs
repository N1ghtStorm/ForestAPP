using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TreeType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Tree> Trees { get; set; }
    }
}
