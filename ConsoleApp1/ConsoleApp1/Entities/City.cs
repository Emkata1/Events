using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{


    public class City
    {
        public int Ìd { get; set; }
        public string Name { get; set; }

        public List<Event> Events { get; set; }
    }
}

