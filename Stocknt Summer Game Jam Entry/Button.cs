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

        //Properties
        public string ActionName { get { return actionName; } set { actionName = value; } }

        //Constructor
        public Button(string actionName, Rectangle position):
            base(position)
        {
            this.actionName = actionName;
        }
    }
}
