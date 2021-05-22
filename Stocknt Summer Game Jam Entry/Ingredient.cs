using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Stocknt_Summer_Game_Jam_Entry
{
    class Ingredient : GameObject
    {
        //Fields
        private string name;

        //Properties
        /// <summary>
        /// Property to get and set the name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        //Constructor
        public Ingredient(string name, Rectangle position):
            base(position)
        {
            this.name = name;
        }
    }
}
