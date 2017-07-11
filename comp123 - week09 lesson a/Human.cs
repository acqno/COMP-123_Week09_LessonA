using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Alvin QUijano
 * Date: July 11, 2017
 * Description: This is the abstract class human which other subclasses will derive from
 * Version: 0.1 - Class created
 */

namespace comp123___week09_lesson_a
{

    /// <summary>
    /// This is the human abstract class
    /// </summary>
    public abstract class Human
    {
        // PRIVATE FIELDS (INSTANCE VARIABLES)-----------------------------------
        private string _name;

        // PUBLIC PROPERTIES----------------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// This is the constructor for the human abstract class.
        /// It requires one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        // Constructors------------------------------------------------
        public Human(string name)
        {
            this.Name = name;
        }
    }
}