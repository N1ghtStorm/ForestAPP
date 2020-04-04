using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Tree
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TreeTypeId { get; set; }

        public int ForestID { get; set; }

        public TreeType TreeType { get; set; }

        public Forest Forest { get; set; }
    }
}
