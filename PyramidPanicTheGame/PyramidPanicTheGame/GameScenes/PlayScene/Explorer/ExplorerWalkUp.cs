﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


//dit is explorerwalkup

namespace PyramidPanic
{
    // Dit is de toestands class van de Explorer    
    public class ExplorerWalkUp : AnimatedSprite, IEntityState
    {
        // Fields
        private Explorer explorer;
        private Vector2 velocity;


        // Constructor van deze toestands class krijgt altijd het object mee
        // van de hoofdclass Explorer als argument
        public ExplorerWalkUp(Explorer explorer)
            : base(explorer)
        {
            this.explorer = explorer;
            this.velocity = new Vector2(0f, this.explorer.Speed);
            this.effect = SpriteEffects.FlipHorizontally;
            this.imageNumber = 1;
            this.sourceRect = new Rectangle(this.imageNumber * 32, 0, 32, 32);
            this.rotation = (float)Math.PI / 2;
        }
        public void Initialize()
        {
            this.destinationRect.X = (int)this.explorer.Position.X;
            this.destinationRect.Y = (int)this.explorer.Position.Y;
        }
        public new void Update(GameTime gameTime)
        {
            this.explorer.Position -= this.velocity;
            this.destinationRect.X = (int)this.explorer.Position.X;
            this.destinationRect.Y = (int)this.explorer.Position.Y;
          
                if (this.explorer.Position.Y < 16)
                {
                    this.explorer.Position += this.velocity;
                    this.explorer.State = this.explorer.IdleWalk;
                    this.explorer.IdleWalk.Initialize();
                    this.explorer.IdleWalk.Effect = SpriteEffects.FlipHorizontally;
                    this.explorer.IdleWalk.Rotation = (float)Math.PI / 2;
                }


            if (Input.LevelDetectKeyUp(Keys.Up))
            {
                this.explorer.State = this.explorer.Idle;
                this.explorer.Idle.Initialize();
                this.explorer.Idle.Rotation = (float)Math.PI / 2 + (float)Math.PI;
                this.explorer.Idle.Effect = SpriteEffects.None;
            }



            // Zorgt voor de animatie 
            base.Update(gameTime);
        }

        public new void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}