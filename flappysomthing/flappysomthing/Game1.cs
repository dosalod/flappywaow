using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flappysomthing {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public enum state { menu, playing, splashscreen,}  
        Texture2D Nurcan,Snickers,Play;
        Bird player = new Bird();
        List<Pipes> obstacle = new List<Pipes>();
        public state CurrentScreen;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            // TODO: Add your initialization logic here
            CurrentScreen = state.playing;
            if (CurrentScreen == state.menu) {
            // TODO: Lägga till start menyn
            }
            if (CurrentScreen == state.playing) {
            // TODO: Fixa rör spawns och player
                obstacle.Add(new Pipes());
                obstacle.Add(new Pipes());

                obstacle[0].Initialize();
                obstacle[0].position.X += 112;

                //Detta är vad marcus har åstakommit
                obstacle[0].position.Y -= 120;
                obstacle[1].Initialize();
                obstacle[1].position.Y += 80;
                //Här slutar det marcus har åstakommit. #Teamproject
      
            }
            if (CurrentScreen == state.splashscreen) {
            // TODO: fixa poäng system osv
            }
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //laddar in sprites
            Play = Content.Load<Texture2D>("play");
            Snickers = Content.Load<Texture2D>("Snickers_wrapped");
            
            obstacle[0].sprite = Content.Load<Texture2D>("NurcanPipe3");
            obstacle[1].sprite = Content.Load<Texture2D>("NurcanPipe3");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
            if (CurrentScreen != state.menu) {
            // TODO: ev lägga till så allt som har med menyn att göra laddas ut
            }
            if (CurrentScreen != state.playing) {
            // TODO: ev lägga till så allt som har med spelet att göra laddas ut
            }
            if (CurrentScreen != state.splashscreen) {
            // TODO: ev lägga till så allt som har med splashscreenen att göra laddas ut
            }
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

            if(CurrentScreen == state.menu) {
            // TODO: Behövs det här ens?
            }
            if (CurrentScreen == state.playing) {
                // TODO: Fixa så alla rör position updateras
                obstacle[0].Update();
                obstacle[1].Update();
            }
            if(CurrentScreen == state.splashscreen) {
            // TODO: Behövs det här ens?
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.White);
            
            spriteBatch.Begin();
            if(CurrentScreen == state.menu) {
            // TODO: Fixa så allt med menyn ritas ut
            }
            if(CurrentScreen == state.playing) {
                // TODO: Fixa så alla rör ritas ut
            spriteBatch.Draw(obstacle[0].sprite, obstacle[0].position, null, null, null, 9.429f);
            spriteBatch.Draw(obstacle[1].sprite, obstacle[1].position, null,null ,null, 0);
            }
            if(CurrentScreen == state.splashscreen) {
            // TODO: Fixa så allt med splashscreenen ritas ut, score, play again osv
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
