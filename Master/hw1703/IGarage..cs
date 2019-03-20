using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    public interface IGarage<T>
    {
        void FixVehicle(T anyVehicle);
        void TakeOutVehicle(T anyVehicle);
        void AddVehicle(T anyVehicle);
    }
}
