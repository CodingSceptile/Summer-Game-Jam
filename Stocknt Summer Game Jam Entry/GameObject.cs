using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Stocknt_Summer_Game_Jam_Entry
{
    class GameObject
    {
        //Fields
        protected Rectangle position;

        //Properties
        /// <summary>
        /// Property to get or set the rectangle of the game object.
        /// </summary>
        public Rectangle Position
        {
            get
            {
                return position;
            }

            set
            {
                if(value.X > 0 && 
                   value.Y > 0)
                {
                    position = value;
                }
            }
        }

        //Constructor
        /// <summary>
        /// Constructor for the GameObject
        /// </summary>
        /// <param name="position">Rectangle of the game object.</param>
        public GameObject(Rectangle position)
        {
            this.position = position;
        }
    }
}
