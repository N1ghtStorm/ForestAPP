using System.Collections.Generic;

namespace Domain.Models
{
    public class Forest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public int ForestTypeId { get; set; }
        public ForestType ForestType { get; set; }

        public List<Tree> Trees { get; set; }
    }
}
