using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    class Bike
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }
        public int EngineVolume { get; private set; }

        public Bike(string brand, bool totalLost, bool needsRepair, int engineVolume)
        {
            this.Brand = brand;
            this.TotalLost = totalLost;
            if (totalLost == true && needsRepair == false)
                throw new RepairMisMAtchException();
            this.NeedsRepair = needsRepair;
            this.EngineVolume = engineVolume;
        }

        public override string ToString()
        {
            return $"Bike: {Brand,12}, Engine Bolume: {EngineVolume, 5}, Total Lost: {TotalLost,6}, Needs Repair: {NeedsRepair,6}";
        }
    }
}
