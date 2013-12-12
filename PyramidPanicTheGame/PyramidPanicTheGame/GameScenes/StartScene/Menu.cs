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
    public class Menu
    {
        #region Fields
        private PyramidPanic game;
        private Image startButton;
        private Image helpButton;
        private Image leveleditorButton;
        private Image loadButton;
        private Image quitButton;
        private Image scoresButton;
        #endregion

        #region Properties

        #endregion


        #region Constructor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }
        #endregion

        #region Initialize
        public void Initialize()
        {
            this.LoadContent();
        }
        #endregion

        #region LoadContent
        public void LoadContent()
        {
            this.startButton = new Image(this.game, @"StartScene\Button_start", new Vector2(10f, 440f));

            this.helpButton = new Image(this.game, @"StartScene\Button_help", new Vector2(10f, 400f));

            this.leveleditorButton = new Image(this.game, @"StartScene\Button_leveleditor", new Vector2(10f, 360f));

            this.loadButton = new Image(this.game, @"StartScene\Button_load", new Vector2(10f, 320f));

            this.scoresButton = new Image(this.game, @"StartScene\Button_scores", new Vector2(10f, 280f));

            this.quitButton = new Image(this.game, @"StartScene\Button_quit", new Vector2(10f, 240f));
        }
        #endregion

        #region Update

        #endregion


        #region Draw
        public void Draw(GameTime gameTime)
        {
            this.quitButton.Draw(gameTime);
            this.scoresButton.Draw(gameTime);
            this.helpButton.Draw(gameTime);
            this.leveleditorButton.Draw(gameTime);
            this.loadButton.Draw(gameTime);
            this.startButton.Draw(gameTime);
            

        }
        #endregion
    }
}