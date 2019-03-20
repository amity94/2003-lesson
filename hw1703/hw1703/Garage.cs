using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    class Garage : IGarage, IEnumerable<Car>
    {
        private List<Car> cars;
        private List<string> carTypes;

        public Garage(List<string> cartype)
        {
            carTypes = cartype;
            cars = new List<Car>();
        }

        public void AddCar(Car anycar)
        {
            if (cars.Contains(anycar))
                throw new CarAlreadyHereException("The Car Is Already In The Garage");
            if (anycar.TotalLost == true)
                throw new WeDoNotFixTotalLostException("We Do Not Fix Total Lost Cars");
            if (carTypes.Contains<string>(anycar.Brand))
                throw new WrongGarageException("This Is The Wrong Garage");
            if (anycar == null)
                throw new CarNullException("Car Has To Be Something");
            if (anycar.NeedsRepair == false)
                throw new RepairMisMAtchException("Car Does Not Need Repairs");

            cars.Add(anycar);
        }        

        public void TakeOutCar(Car anycar)
        {
            if (anycar == null)
                throw new CarNullException("Car Has To Be Something");
            if (!cars.Contains(anycar))
                throw new CarNotInGarageException("The Car Is Not In The Garage");
            if (anycar.NeedsRepair == true)
                throw new CarNotReadyException("The Car Is Not Ready Yet");

            cars.Remove(anycar);
        }

        public void FixCar(Car anycar)
        {
            if (anycar == null)
                throw new CarNullException("Car Has To Be Something");
            if (!cars.Contains(anycar))
                throw new CarNotInGarageException("The Car Is Not In The Garage");
            if (anycar.NeedsRepair == false)
                throw new RepairMisMAtchException("Car Does Not Need Repair");
            anycar.NeedsRepair = false;
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        public Car this [int index]
        {
            get
            {
                return cars[index];
            }
        }
    }
}
