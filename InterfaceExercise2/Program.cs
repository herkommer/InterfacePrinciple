using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            IRepository repo = new MongoDBCarDataStorage();
            repo.AddNewCar(c);

        }
    }

    interface IRepository
    {
        int GetNumberOfCars();
        void AddNewCar(Car c);

        void RemoveCar(Car c);
    }

    //Concrete
    class JsonCarData : IRepository
    {
        public void AddNewCar(Car c)
        {
            Console.WriteLine("Add new car in JSON");
        }

        public int GetNumberOfCars()
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Car c)
        {
            throw new NotImplementedException();
        }
    }

    class MongoDBCarDataStorage : IRepository
    {
        public void AddNewCar(Car c)
        {
            Console.WriteLine("Adding car to MongoDB Atlas");
        }

        public int GetNumberOfCars()
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Car c)
        {
            throw new NotImplementedException();
        }
    }

    class Car
    {

    }
}
