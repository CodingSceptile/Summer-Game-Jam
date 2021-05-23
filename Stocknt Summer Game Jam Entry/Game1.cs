using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Stocknt_Summer_Game_Jam_Entry
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //My fields
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

        //Misc
        MouseState mouseState;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
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
            oilTexture = Content.Load<Texture2D>("ajay_suresh olive oil");
            chickenTexture = Content.Load<Texture2D>("scott_rubin chicken");
            carrotTexture = Content.Load<Texture2D>("carrots");
            onionTexture = Content.Load<Texture2D>("onions");

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
