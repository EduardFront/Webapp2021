using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Price { get; set; }
        public bool isActive { get; set; }
 

    }
}
