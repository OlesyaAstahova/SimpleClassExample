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

        public Bike(int Speed = 0, string name = "")
        {

       /* //Связывание конструктора в цепочку
        public Bike(int Speed)
            : this(Speed, "") { }
        public Bike(string name)
            : this(0, name) { }

        // Специальный стандартный конструктор.
        public Bike()
        {
            bikeName = "Sony";
            bikeSpeed = 4;
        }
        public Bike(int Speed, string name)
        {*/
            if (Speed > 10)
            {
                Speed = 10;
            }
            bikeSpeed = Speed;
            bikeName = name;
        }
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        //Стандартное значение для типа int (0)
       
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
