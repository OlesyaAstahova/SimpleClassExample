using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Bike
    {
        //'Состояние ' объект Bike.
        public string bikeName;
        public int bikeSpeed;

        // Специальный стандартный конструктор.
        public Bike()
        {
            bikeName = "Sony";
            bikeSpeed = 4;
        }

        //Стандартное значение для типа int (0)
        public Bike(string pn)
        {
            bikeName = pn;
        }
        // Установка кодом полного состояния Bike.
        public Bike(string pn, int cs)
        {
            bikeName = pn;
            bikeSpeed = cs;
        }
        // Функциональность Bike.
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", bikeName, bikeSpeed);
        }

        public void SpeedUp(int delta)
        {
            bikeSpeed += delta;
        }
    }
}
