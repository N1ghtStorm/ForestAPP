using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class ForestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int ForestTypeId { get; set; }
    }
}
