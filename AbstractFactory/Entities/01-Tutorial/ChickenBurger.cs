﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entities._01_Tutorial
{
    public class ChickenBurger : IBurger
    {
        public void Prepare()
        {
            Console.WriteLine("Preparando hamburguesa de pollo");
        }
    }
}
