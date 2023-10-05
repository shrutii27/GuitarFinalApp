using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarFinalApp.Model
{
    internal class Guitar
    {
        internal string SerialNumber { get; }
        internal double Price { get; set; }

        internal GuitarSpec Spec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }
    }
}


