using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{

    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //fields, de velden van deze class
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private KeyboardState ks, oldks;

        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            //Dit maakt de muis zichtbaar in het scherm van het spel
            IsMouseVisible = true;
        }


        protected override void Initialize()
        {
            // Veranderd de titel van het canvas
            this.Window.Title = "Pyramid Panic";

            // Verandered de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;

            // Veranderd de hoogte van het canvas
            this.graphics.PreferredBackBufferHeight = 480;

            // Past de veranderingen bretffende canvas toe
            this.graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void UnloadContent()
        {

        }

    
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            if (this.ks.IsKeyDown(Keys.Escape))
                this.Exit();

            this.ks = Keyboard.GetState();

            this.oldks = this.ks;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
