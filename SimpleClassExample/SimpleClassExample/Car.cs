﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //'Состояние ' объект Car.
        public string petName;
        public int currSpeed;

        // Специальный стандартный конструктор.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //Стандартное значение для типа int (0)
        public Car(string pn)
        {
            petName = pn;
        }
        // Установка кодом полного состояния Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        // Функциональность Car.
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
