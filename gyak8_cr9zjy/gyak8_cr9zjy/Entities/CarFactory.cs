using gyak8_cr9zjy.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8_cr9zjy.Entities
{
    public class CarFactory : Abstractions.IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
