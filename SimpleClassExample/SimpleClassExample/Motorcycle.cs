using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle(int intensity = 0, string name = "")
        {

      /*  }

            public Motorcycle() { }
        //Связывание конструктора в цепочку
        public Motorcycle(int intensity)
            : this(intensity, "") { }
        public Motorcycle(string name)
            : this(0, name) { }

        public Motorcycle(int intensity, string name)
        {*/
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        //Новые члены для представления имени водителя
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAwheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeee Haaaaaaeewww!");
            }
        }
      
    }
}
