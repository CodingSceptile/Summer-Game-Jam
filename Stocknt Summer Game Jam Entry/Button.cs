using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Stocknt_Summer_Game_Jam_Entry
{
    class Button : GameObject
    {
        //Fields
        private string actionName;
        private SpriteFont spriteFont;

        //Properties
        public string ActionName { get { return actionName; } set { actionName = value; } }

        //Constructor
        public Button(string actionName, Rectangle position, Texture2D texture, SpriteFont spriteFont):
            base(position, texture)
        {
            this.actionName = actionName;
            this.spriteFont = spriteFont;
        }

        //Methods
        public override void Draw(SpriteBatch sb)
        {
            base.Draw(sb);
            sb.DrawString(spriteFont,
                          actionName,
                          new Vector2(position.X, position.Y),
                          Color.Black);
        }
    }
}
