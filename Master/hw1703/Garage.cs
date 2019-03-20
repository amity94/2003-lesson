using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    public class Garage<T> : IGarage<T>, IEnumerable<T> where T: IVehicle
    {
        private List<T> cars;
        private List<string> carTypes;

        public Garage(List<string> cartype)
        {
            carTypes = cartype;
            cars = new List<T>();
        }

        public void AddVehicle(T anyVehicle)
        {
            if (anyVehicle == null)
                throw new CarNullException("Car Has To Be Something");
            if (cars.Contains(anyVehicle))
                throw new CarAlreadyHereException("The Car Is Already In The Garage");
            if (anyVehicle.TotalLost == true && anyVehicle.CanFixTotalLost == false)
                throw new WeDoNotFixTotalLostException("We Do Not Fix Total Lost");
            if (!carTypes.Contains<string>(anyVehicle.Brand))
                throw new WrongGarageException("This Is The Wrong Garage");
            if (anyVehicle.NeedsRepair() == false)
                throw new RepairMisMAtchException("Car Does Not Need Repairs");

            cars.Add(anyVehicle);
        }

        public void TakeOutVehicle(T anyVehicle)
        {
            if (anyVehicle == null)
                throw new CarNullException("Car Has To Be Something");
            if (!cars.Contains(anyVehicle))
                throw new CarNotInGarageException("The Car Is Not In The Garage");
            if (anyVehicle.NeedsRepair() == true)
                throw new CarNotReadyException("The Car Is Not Ready Yet");

            cars.Remove(anyVehicle);
        }

        public void FixVehicle(T anyVehicle)
        {
            if (anyVehicle == null)
                throw new CarNullException("Car Has To Be Something");
            if (!cars.Contains(anyVehicle))
                throw new CarNotInGarageException("The Car Is Not In The Garage");
            if (anyVehicle.NeedsRepair() == false)
                throw new RepairMisMAtchException("Car Does Not Need Repair");
            anyVehicle.NeedsRepair();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }


        public T this [int index]
        {
            get
            {
                return cars[index];
            }
        }
    }
}
