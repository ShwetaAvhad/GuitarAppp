using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppp
{ 
    public class Guitar
    {        
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        GuitarSpec spec;
        public Guitar(string number,double price,GuitarSpec guitarSpec)
        {
            SerialNumber = number;
            Price = price;
            spec = guitarSpec;
        }
        public GuitarSpec GetGuitarSpec()
        {
            return spec; 
        }
    }
}
