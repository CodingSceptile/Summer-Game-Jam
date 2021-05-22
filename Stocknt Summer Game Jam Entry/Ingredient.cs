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
        private Random rng;

        //Properties
        /// <summary>
        /// Property to get and set the name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        //Constructor
        public Ingredient(string name, Rectangle position, Texture2D texture):
            base(position, texture)
        {
            this.name = name;
            rng = new Random();
        }

        /// <summary>
        /// Draws the ingredient in the bowl.
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="bowl"></param>
        public void DrawInBowl(SpriteBatch sb, Bowl bowl)
        {
            //Randomizes position of the ingredient placed within the bowl.
            int Xvalue = rng.Next(bowl.Position.X, bowl.Position.X + bowl.Position.Width);
            int Yvalue = rng.Next(bowl.Position.Y, bowl.Position.Y + bowl.Position.Height);
            sb.Draw(texture,
                    new Rectangle(Xvalue, Yvalue, position.Width, position.Height),
                    Color.White);
        }
    }
}
