using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace swspelgejm
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
  Texture2D Player;
        Vector2 playerPosition= new Vector2(0, 0);
        Rectangle playerrect = new Rectangle(200, 200, 120, 120);
        
Texture2D Background;
    Vector2 BackgroundPosition= new Vector2(0, 0);
    Rectangle Backgroundrect = new Rectangle(0, 0, 820, 700);

Texture2D playershot;
      Vector2 playershotPosition= new Vector2(50, 50);
    Rectangle playershotrect = new Rectangle(0, 0, 4, 1);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.ToggleFullScreen();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            

             Background=this.Content.Load<Texture2D>("gameing background");
             Player=this.Content.Load<Texture2D>("player");
             playershot=this.Content.Load<Texture2D>("player shot");

            // TODO: use this.Content to load your game content here
        
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
 int speed= 6;

             if(Keyboard.GetState().IsKeyDown(Keys.D)){
                 playerrect.X += speed;
             }

             if(Keyboard.GetState().IsKeyDown(Keys.A)){
                 playerrect.X -= speed;
             }

             if(Keyboard.GetState().IsKeyDown(Keys.S)){
                 playerrect.Y += speed;

             }
              if(Keyboard.GetState().IsKeyDown(Keys.W)){
                 playerrect.Y -= speed;

             }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
         _spriteBatch.Begin();

              _spriteBatch.Draw(Background, Backgroundrect, Color.White);
              _spriteBatch.Draw(Player, playerrect, Color.White);
              _spriteBatch.Draw(playershot, playershotrect, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
