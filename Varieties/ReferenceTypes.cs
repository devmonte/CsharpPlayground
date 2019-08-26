using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varieties
{
    public class Car
    {
        public string Name { get; set; }
    }

    public class ReferenceTypes
    {
        public void ChangeCarName(Car car)
        {
            car.Name = "ChangedName";
            car = new Car { Name = "NAmeInNewCarInstance" };
        }

    }
}
