using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin Quijano
 * Date: July 11, 2017
 * Description: This is the power class
 * Version: 0.1 - Power class created
 */

namespace comp123___week09_lesson_a
{

    /// <summary>
    /// The power class contains the data and structure of each super power
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        /// <summary>
        /// This is the power constructor
        /// Takes two parameters - name (string) - rank (int)
        /// </summary>
        // CONSTRUCTORS ---------------------------------------------------
        public Power(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }
    }
}