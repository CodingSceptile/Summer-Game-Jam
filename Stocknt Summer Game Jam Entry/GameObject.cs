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
        protected Texture2D texture;
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

        /// <summary>
        /// Property to get and set 2D texture.
        /// </summary>
        public Texture2D Texture { get { return texture; } set { texture = value; } }

        //Constructor
        /// <summary>
        /// Constructor for the GameObject
        /// </summary>
        /// <param name="position">Rectangle of the game object.</param>
        public GameObject(Rectangle position, Texture2D texture)
        {
            this.position = position;
            this.texture = texture;
        }

        //Methods
        /// <summary>
        /// A draw method that can be overriden by child classes.
        /// </summary>
        /// <param name="sb"></param>
        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(texture, Position, Color.White);
        }
    }
}
