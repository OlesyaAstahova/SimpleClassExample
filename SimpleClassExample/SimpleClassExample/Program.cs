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
            //Усадим на мотоцикл байкера по имени Tiny.
              Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAwheely();
            Console.WriteLine("rider name is {0}", c.name);//name=NULL
            Console.WriteLine("Thanks ...");

         /* Console.WriteLine("***** Fun with Class Bike *****\n");
            Bike sony = new Bike();
            sony.PrintState();
            Bike pony = new Bike("Pony",2);
            pony.PrintState();
            Bike tony = new Bike("Tony", 6);
            tony.PrintState(); */



            /*  // Console.WriteLine("***** Fun with Class Types *****\n");
             //Разместить в памяти и сконфигурировать объект Car.
             Car myCar = new Car();
             myCar.petName = "Henry";
             myCar.currSpeed = 10;

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
             }*/
            Console.ReadLine();
        }

    }
        
}
