using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Alvin Quijano
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.1 - instantiated an object of typpe Super Human
 */

namespace comp123___week09_lesson_a
{
    class Program
    {
        static void Main(string[] args)
        {            
            SuperHuman superhuman = new SuperHuman("super dude");
            superhuman.AddPower("Spider Climbing", 50);
            superhuman.AddPower("Webcasting", 40);
            Console.WriteLine(superhuman.ToString());          
        }
    }
}
