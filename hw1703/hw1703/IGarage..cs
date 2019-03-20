using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    interface IGarage
    {
        void FixCar(Car anycar);
        void TakeOutCar(Car anycar);
        void AddCar(Car anycar);
    }
}
