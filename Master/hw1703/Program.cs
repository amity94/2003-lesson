using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1703
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("honda", false, false);
            Car b = new Car("not honda", true, true);
            Console.WriteLine("=====================================");
            Console.WriteLine("With Simple Console.WriteLine");
            Console.WriteLine(c);
            Console.WriteLine(b);
            /*
            List<string> hondatype = new List<string>();
            Garage<Car> mygarage = new Garage<Car>(hondatype);
            mygarage.AddCar(c);
            mygarage.AddCar(b);

            Console.WriteLine("=====================================");
            Console.WriteLine("With ForEach");
            foreach(var car in mygarage)
                Console.WriteLine(car);
            Console.WriteLine("=====================================");
            Console.WriteLine("With Indexer");
            Console.WriteLine(mygarage[0]);
            Console.WriteLine(mygarage[1]);
            Console.WriteLine("=====================================");

            Car a = new Car("Dihatsu", false, false);
            Car d = new Car("Hyundai", true, true);

            mygarage.AddCar(a);
            mygarage.AddCar(d);
            foreach (var car in mygarage)
                Console.WriteLine(car);
            Console.WriteLine("=====================================");

            mygarage.TakeOutCar(a);
            foreach (var car in mygarage)
                Console.WriteLine(car);
            try
            {
                mygarage.AddCar(b);
            }
            catch(CarAlreadyHereException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
