using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using hw1703;

namespace hw1703Test
{
    [TestClass]
    public class UnitTest1
    {
        /*
        void FixCar(T anycar);
        void TakeOutCar(T anycar);
        void AddCar(T anycar);

            All Exceptions
        */
        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void FixCarTestCarNullException()
        {
            IGarage<Car> carGarage = new Garage<Car>(new List<string>() {
                "Honda", "Mitsubishi", "Fiat" } );

            carGarage.AddVehicle(null);
        }

        [TestMethod]
        public void FixCarTestAddVehicle_Car()
        {
            Garage<Car> carGarage = new Garage<Car>(new List<string>()
            {
                "Honda", "Mitsubishi", "Fiat"
            }
            );

            Car c = new Car("Honda", false, true);
            carGarage.AddVehicle(c);

            foreach(Car aCar in carGarage)
            {
                Assert.AreEqual(aCar, c);
            }
        }
    }
}
