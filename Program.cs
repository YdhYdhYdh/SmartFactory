﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Class_20180912
{
    class Program
    {
        static void Print(string name, string phone)
        {
            WriteLine($"이름 : {name}, 번호 : {phone}");
	WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; ++i)
                WriteLine(i + " Hello");

            Print(name: "유형민", phone: "010-4489-9371");

            InitIronMan ArmorSuite = new InitIronMan();
            ArmorSuite.Initialize();

            InitIronMan IronMan = new IronMan();
            IronMan.Initialize();

            InitIronMan ArmorSuite2 = new ArmorSuite();
            ArmorSuite2.Initialize();
        }

    }

    class InitIronMan
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armor Suite");
        }
    }
}
<<<<<<< HEAD
*/
=======

//수정!
>>>>>>> 1b85a7676c5c71da959bf806548feb8fbb539d69

//git