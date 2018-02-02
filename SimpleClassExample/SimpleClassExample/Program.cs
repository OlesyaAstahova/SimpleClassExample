using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** Fun with Class Types *****\n");
            //Разместить в памяти и сконфигурировать объект Car.
            //Car myCar = new Car();
            //myCar.petName = "Henry";
            //myCar.currSpeed = 10;
            Console.WriteLine("***** Fun with Class Types *****\n");
            Car chuck = new Car();
            chuck.PrintState();
            Car mary = new Car("Mary");
            mary.PrintState();
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            Car myCar;
            myCar = new Car();
            myCar.petName = "Fred";
            // Увиличить скорость автомобиля в несколько раз и вывести новое состояние.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
    
}
