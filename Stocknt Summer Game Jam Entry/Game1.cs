using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocknt_Summer_Game_Jam_Entry
{
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
        SpriteFont arial12;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //Rectangles are temporary, will change them to real stuff when I wake up
            oliveOil = new Ingredient("Olive Oil", new Rectangle(), oilTexture);
            chicken = new Ingredient("Chicken", new Rectangle(), chickenTexture);
            carrots = new Ingredient("Carrots", new Rectangle(), carrotTexture);
            onions = new Ingredient("Onions", new Rectangle(), onionTexture);
            celeryWithLeaves = new Ingredient("Celery with leaves", new Rectangle(), celeryTexture);
            dryWhiteWine = new Ingredient("Dry White Wine", new Rectangle(), wineTexture);
            pepperCorns = new Ingredient("Pepper corns", new Rectangle(), pepperCornTexture);
            cloves = new Ingredient("Cloves", new Rectangle(), cloveTexture);
            bayLeaves = new Ingredient("Bay leaves", new Rectangle(), bayLeavesTexture);
            sprigFreshThyme = new Ingredient("Sprig Fresh Thyme", new Rectangle(), thymeTexture);
            water = new Ingredient("Water", new Rectangle(), waterTexture);

            //Buttons, same Rectangle clause applies
            preheat = new Button("Preheat", new Rectangle(), buttonTexture, arial12);
            roast = new Button("Roast", new Rectangle(), buttonTexture, arial12);
            stir = new Button("Stir", new Rectangle(), buttonTexture, arial12);
            refrigerate = new Button("Refrigerate", new Rectangle(), buttonTexture, arial12);
            filter = new Button("Filter", new Rectangle(), buttonTexture, arial12);

            //Now to load up the steps
            List<GameObject> order = new List<GameObject>();
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

            bowl = new Bowl(order, new Rectangle(), bowlTexture);

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
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
