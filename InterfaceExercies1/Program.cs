using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercies1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Accelerate();
            c.Indicate("left");
            c.Accelerate();
            c.Brake();
            c.Indicate("right");
           

            //
            ICar myCar = new Car();
            ICarService myCarService = new Car();

            
            

        }
    }

    //Abstract, no code only really good naming
    interface ICar
    {
        void Brake();
        void Accelerate();
        void Indicate(string parameter);

    }
    interface ICarService
    {
        int OilPressure();
    }

    //Concrete, implements Interface
    class Car : ICar, ICarService
    {
        public int OilPressure()
        {
            return 42;
        }
        public void Brake()
        {
            Console.WriteLine("Car is braking");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating");

        }

        public void Indicate(string parameter)
        {
            if (parameter == "left")
            {
                Console.WriteLine("Indicating left turn");
            }
            if (parameter == "right")
            {
                Console.WriteLine("Indicating right turn");
            }
        }
    }
}
