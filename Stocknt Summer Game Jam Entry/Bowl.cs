using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Stocknt_Summer_Game_Jam_Entry
{
    class Bowl : GameObject
    {
        //fields
        private List<GameObject> orderToMake;
        private List<GameObject> currentOrder;
        private bool correctOrder;

        //Properties
        /// <summary>
        /// Property to get and set the current order the bowl's in.
        /// </summary>
        public List<GameObject> CurrentOrder { get { return currentOrder; } }
        
        /// <summary>
        /// Property to get the fixed order to make the stock in.
        /// </summary>
        public List<GameObject> OrderToMake { get { return orderToMake; } }

        /// <summary>
        /// Property to check if the current order in the soup stock is correct.
        /// </summary>
        public bool CorrectOrder { get { return correctOrder; } }

        //Constructor
        public Bowl(List<GameObject> orderToMake, Rectangle position, Texture2D texture):
            base(position, texture)
        {
            this.orderToMake = orderToMake;
            currentOrder = new List<GameObject>();
        }

        //Methods
        /// <summary>
        /// Adds something to the bowl. This could mean an ingredient
        /// was added or it could mean an action was done to the bowl.
        /// </summary>
        /// <param name="ingredientOrAction"></param>
        public void AddStep(GameObject ingredientOrAction)
        {
            currentOrder.Add(ingredientOrAction);
            OrderCheck();
        }

        /// <summary>
        /// Bowl is cleared out to start fresh.
        /// </summary>
        public void ClearBowl()
        {
            currentOrder.Clear();
        }

        /// <summary>
        /// Checks if the order the stock is being prepared in is 
        /// correct so far.
        /// </summary>
        /// <returns></returns>
        public bool OrderCheck()
        {
            for(int i = 0; i < currentOrder.Count; i++)
            {
                correctOrder = true;
                //For now it raw equates but this probably won't work and will need
                //finer string checks, but is fine for the base cose
                if(currentOrder[i] is Button && orderToMake[i] is Button)
                {
                    Button button = (Button)currentOrder[i];
                    Button correctButton = (Button)orderToMake[i];
                    if(button.ActionName.Equals(correctButton.ActionName))
                    {
                        continue;
                    }

                    else
                    {
                        correctOrder = false;
                        break;
                    }
                }

                else if(currentOrder[i] is Ingredient && orderToMake[i] is Ingredient)
                {
                    Ingredient ingredient = (Ingredient)currentOrder[i];
                    Ingredient correctIngredient = (Ingredient)orderToMake[i];
                    if(ingredient.Name.Equals(correctIngredient.Name))
                    {
                        continue;
                    }

                    else
                    {
                        correctOrder = false;
                        break;
                    }

                }

                else
                {
                    correctOrder = false;
                    break;
                }
            }

            return correctOrder;
        }

        /// <summary>
        /// Draws the bowl and also the ingredients in the bowl.
        /// </summary>
        /// <param name="sb"></param>
        public override void Draw(SpriteBatch sb, MouseState mouseState, SpriteFont spriteFont)
        {
            if (correctOrder)
            {
                sb.Draw(texture, Position, Color.Green);
            }

            else
            {
                sb.Draw(texture, Position, Color.Red);
            }
            
            for(int i = 0; i < currentOrder.Count; i++)
            {
                if(currentOrder[i] is Ingredient)
                {
                    Ingredient ingredient = (Ingredient)currentOrder[i];
                    ingredient.DrawInBowl(sb, this);
                }
            }
        }
    }
}
