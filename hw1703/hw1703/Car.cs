using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    class Car
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            this.Brand = brand;
            this.TotalLost = totalLost;
            if (totalLost == true && needsRepair == false)
                throw new RepairMisMAtchException();
            this.NeedsRepair = needsRepair;
        }

        public override string ToString()
        {                   
            return $"Car: {Brand, 12}, Total Lost: {TotalLost, 6}, Needs Repair: {NeedsRepair, 6}";
        }
    }
}
