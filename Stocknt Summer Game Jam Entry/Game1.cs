using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocknt_Summer_Game_Jam_Entry
{
    public enum GameStates
    {
        Menu,
        Game,
        Recipe,
        Victory,
        Loss,
        Credits
    }
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //My fields
        Bowl bowl;

        //Buttons
        Button preheat;
        Button roast;
        Button stir;
        Button refrigerate;
        Button filter;

        //Non-game buttons
        Button play;
        Button restart;
        Button credits;
        Button reset;

        //Ingredients
        Ingredient oliveOil;
        Ingredient chicken;
        Ingredient carrots;
        Ingredient onions;
        Ingredient celeryWithLeaves;
        Ingredient dryWhiteWine;
        Ingredient pepperCorns;
        Ingredient cloves;
        Ingredient bayLeaves;
        Ingredient sprigFreshThyme;
        Ingredient water;

        //Textures
        Texture2D buttonTexture;
        Texture2D oilTexture;
        Texture2D chickenTexture;
        Texture2D carrotTexture;
        Texture2D onionTexture;
        Texture2D celeryTexture;
        Texture2D wineTexture;
        Texture2D pepperCornTexture;
        Texture2D cloveTexture;
        Texture2D bayLeavesTexture;
        Texture2D thymeTexture;
        Texture2D waterTexture;
        Texture2D bowlTexture;

        //Misc
        MouseState mouseState;
        MouseState prevMouseState;
        SpriteFont arial12;
        List<GameObject> order;
        GameStates gameState;

         public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            gameState = GameStates.Menu;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            arial12 = Content.Load<SpriteFont>("arial12");

            oilTexture = Content.Load<Texture2D>("ajay_suresh olive oil");
            chickenTexture = Content.Load<Texture2D>("scott_rubin chicken");
            carrotTexture = Content.Load<Texture2D>("carrots");
            onionTexture = Content.Load<Texture2D>("onions");
            celeryTexture = Content.Load<Texture2D>("keepon_i celery");
            wineTexture = Content.Load<Texture2D>("WHP Wine");
            pepperCornTexture = Content.Load<Texture2D>("Laura_Shefler peppercorn");
            cloveTexture = Content.Load<Texture2D>("anuandraj cloves");
            bayLeavesTexture = Content.Load<Texture2D>("camilla_karstensen bay leaves");
            thymeTexture = Content.Load<Texture2D>("thyme");
            waterTexture = Content.Load<Texture2D>("water");
            bowlTexture = Content.Load<Texture2D>("madichan bowl");
            buttonTexture = Content.Load<Texture2D>("button");

            oliveOil = new Ingredient("Olive Oil", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 20,
                                                                 30,
                                                                 30),
                                                                 oilTexture);
            chicken = new Ingredient("Chicken", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 60,
                                                                 30,
                                                                 30),
                                                                 chickenTexture);
            carrots = new Ingredient("Carrots", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 100,
                                                                 30,
                                                                 30),
                                                                 carrotTexture);
            onions = new Ingredient("Onions", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 140,
                                                                 30,
                                                                 30),
                                                                 onionTexture);
            celeryWithLeaves = new Ingredient("Celery with leaves", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 180,
                                                                 30,
                                                                 30),
                                                                 celeryTexture);
            dryWhiteWine = new Ingredient("Dry White Wine", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 220,
                                                                 30,
                                                                 30),
                                                                 wineTexture);
            pepperCorns = new Ingredient("Pepper corns", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 260,
                                                                 30,
                                                                 30),
                                                                 pepperCornTexture);
            cloves = new Ingredient("Cloves", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 300,
                                                                 30,
                                                                 30),
                                                                 cloveTexture);
            bayLeaves = new Ingredient("Bay leaves", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 340, 
                                                                 30,
                                                                 30),
                                                                 bayLeavesTexture);
            sprigFreshThyme = new Ingredient("Sprig Fresh Thyme", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 380,
                                                                 30,
                                                                 30),
                                                                 thymeTexture);
            water = new Ingredient("Water", new Rectangle(_graphics.PreferredBackBufferWidth - 50,
                                                                 420, //nice
                                                                 30,
                                                                 30),
                                                                 waterTexture);

            //Buttons, same Rectangle clause applies
            preheat = new Button("Preheat", new Rectangle(50,
                                                          20,
                                                          70,
                                                          40),
                                                          buttonTexture, arial12);
            roast = new Button("Roast", new Rectangle(50,
                                                      70,
                                                      70,
                                                      40), buttonTexture, arial12);
            stir = new Button("Stir", new Rectangle(50,
                                                    120,
                                                    70,
                                                    40), buttonTexture, arial12);
            refrigerate = new Button("Refrigerate", new Rectangle(50,
                                                                  170,
                                                                  70,
                                                                  40), buttonTexture, arial12);
            filter = new Button("Filter", new Rectangle(50,
                                                        220,
                                                        70,
                                                        40), buttonTexture, arial12);

            play = new Button("Play", new Rectangle(_graphics.PreferredBackBufferWidth/2 - 40,
                                                    _graphics.PreferredBackBufferHeight/2 - 25,
                                                    80,
                                                    50), buttonTexture, arial12);

            restart = new Button("Restart", new Rectangle(_graphics.PreferredBackBufferWidth/2 - 40,
                                                    _graphics.PreferredBackBufferHeight/2 - 25,
                                                    80,
                                                    50), buttonTexture, arial12);

            credits = new Button("Restart", new Rectangle(_graphics.PreferredBackBufferWidth/2 - 40,
                                                    _graphics.PreferredBackBufferHeight/2 - 85,
                                                    80,
                                                    50), buttonTexture, arial12);

            reset = new Button("Reset", new Rectangle((_graphics.PreferredBackBufferWidth/2 - 40),
                                                     10,
                                                     70,
                                                     40), buttonTexture, arial12);
            //Now to load up the steps
            order = new List<GameObject>();
            order.Add(preheat);
            order.Add(oliveOil);
            order.Add(chicken);
            order.Add(carrots);
            order.Add(onions);
            order.Add(celeryWithLeaves);
            order.Add(roast);
            order.Add(stir);
            order.Add(dryWhiteWine);
            order.Add(pepperCorns);
            order.Add(cloves);
            order.Add(bayLeaves);
            order.Add(sprigFreshThyme);
            order.Add(water);
            order.Add(filter);
            order.Add(refrigerate);

            bowl = new Bowl(order, new Rectangle(_graphics.PreferredBackBufferWidth / 2 - 100,
                                                 _graphics.PreferredBackBufferHeight / 2 - 100,
                                                 200,
                                                 200), bowlTexture);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            mouseState = Mouse.GetState();
            switch(gameState)
            {
                case GameStates.Menu:
                    
                    if(play.Clicked(mouseState, prevMouseState))
                    {
                        gameState = GameStates.Game;
                    }

                    if(credits.Clicked(mouseState, prevMouseState))
                    {
                        gameState = GameStates.Credits;
                    }

                    break;

                case GameStates.Game:
                    
                    for (int i = 0; i < order.Count; i++)
                    {
                        order[i].Clicked(mouseState, prevMouseState, bowl);
                    }

                    if (bowl.CurrentOrder.Count == bowl.OrderToMake.Count)
                    {
                        if (bowl.CorrectOrder)
                            gameState = GameStates.Victory;

                        else
                            gameState = GameStates.Loss;
                    }

                    if (mouseState.RightButton == ButtonState.Pressed)
                    {
                        gameState = GameStates.Recipe;
                    }

                    if(reset.Clicked(mouseState, prevMouseState))
                    {
                        bowl.ClearBowl();
                    }

                    break;
               
               case GameStates.Recipe:

                    if(mouseState.RightButton == ButtonState.Released)
                    {
                        gameState = GameStates.Game;
                    }

                    break;

                case GameStates.Loss:

                    if (restart.Clicked(mouseState, prevMouseState))
                    {
                        bowl.ClearBowl();
                        gameState = GameStates.Game;
                    }

                    break;

                case GameStates.Victory:
                    
                    if (restart.Clicked(mouseState, prevMouseState))
                    {
                        bowl.ClearBowl();
                        gameState = GameStates.Game;
                    }
                    break;
            }
            

            prevMouseState = mouseState;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin();
           
            //Since all the stuff that's to be clicked is in the array I can just use that I think
            switch(gameState)
            {
                case GameStates.Menu:

                    _spriteBatch.DrawString(arial12,
                                           "Stockn't: No soup",
                                           new Vector2(_graphics.PreferredBackBufferWidth / 2 - 40,
                                                       40),
                                           Color.White);
                    play.Draw(_spriteBatch);
                    credits.Draw(_spriteBatch);

                    break;

                case GameStates.Game:

                    for (int i = 0; i < order.Count; i++)
                    {
                        order[i].Draw(_spriteBatch, mouseState);
                    }

                    reset.Draw(_spriteBatch, mouseState);
                    bowl.Draw(_spriteBatch, mouseState);

                    _spriteBatch.DrawString(arial12,
                                            "Hold right click to view the recipe",
                                            new Vector2(_graphics.PreferredBackBufferWidth / 2 - 50,
                                                        _graphics.PreferredBackBufferHeight - 20),
                                            Color.White);
                    break;

                case GameStates.Recipe:

                    _spriteBatch.DrawString(arial12,
                                            "1. Preheat the oven" +
                                            "\n2. Add olive oil, chicken, carrots, and onions, in that order" +
                                            "\n3. Then add the celery before roasting the mixture." +
                                            "\n4. After roasting it, stir the mixture and then add dry white wine to it." +
                                            "\n5. Add peppercorns, cloves, bay leaves and thyme in that order." +
                                            "\n6. Add water before filtering out the mixture and then refrigerate it." +
                                            "\n7. Stock is ready!",
                                            new Vector2(_graphics.PreferredBackBufferWidth/2 - 120,
                                                        10),
                                            Color.White);

                    break;

                case GameStates.Loss:

                    _spriteBatch.DrawString(arial12, "That's tough. Better luck next time",
                                            new Vector2(_graphics.PreferredBackBufferWidth/2,
                                                        _graphics.PreferredBackBufferHeight/2 - 70),
                                            Color.White);
                    restart.Draw(_spriteBatch);

                    break;

                case GameStates.Victory:

                    _spriteBatch.DrawString(arial12, "GG go have some soup.",
                                            new Vector2(_graphics.PreferredBackBufferWidth/2,
                                                        _graphics.PreferredBackBufferHeight/2 - 70),
                                            Color.White);
                    restart.Draw(_spriteBatch);

                    break;
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
