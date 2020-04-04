using System.Collections.Generic;

namespace Domain.Models
{
    public class ForestType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Forest> Forests { get; set; }
    }
}
