using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.Models
{
    public class Car
    {
        public int Id { get; set; }

        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
    }
}
