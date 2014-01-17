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
    public class Beetle
    {
        // Fields
        private Vector2 position;
        private int speed;
        private PyramidPanic game;
        private IBeetleState state;

        //Properties
        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public PyramidPanic Game
        {
            get { return this.game; }
        }
        public int Speed
        {
            get { return this.speed;}
        }
        public IBeetleState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Constructor
        public Beetle(PyramidPanic game, Vector2 position)
        {
            this.position = position;
            this.game = game;
        }

        // Update
        public void Update(GameTime gameTime)
        {
            this.state.Update(gameTime);
        }

        // Draw
        public void Draw(GameTime gameTime)
        {
            this.state.Draw(gameTime);
        }
    }
}
