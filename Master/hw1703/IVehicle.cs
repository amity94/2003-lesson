using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    public interface IVehicle
    {
        string Brand { get; }
        bool TotalLost { get; }
        bool NeedsRepair();

        bool CanFixTotalLost { get; }
    }
}
