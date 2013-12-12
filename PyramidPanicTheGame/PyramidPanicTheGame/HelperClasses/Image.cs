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

namespace PyramidPanic.HelperClasses
{
    public class Image
    {
        
        #region Fields
		 /* Fields zijn private en zijn alleen beschikbaar binnen de class . Ze wordenn ook wel 
          * class variables genoemd
          */

         /* Met een Texture2D kun je een plaatje zichtbaar maken. Is eigenlijk een soort houten
          * bord waar je een poster op kunt plakken
          */
        private Texture2D texture;

        /* De rectangle gebruiken we voor collisiondetection
         */

	    #endregion

        #region Properties
        
        #endregion

        #region Contructor
        /* Dit is de contructor van de Image class. Hij is meestal public, heeft
         * dezelfde naam als de class en heeft geen returntype.
         */
          public Image(PyramidPanic game, string pathNameAsset, Vector2 position)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(pathNameAsset);
            this.rectangle = new Rectangle((int)position.X,
                                           (int)position.Y,
                                            this.texture.Width,
                                            this.texture.Height);
                                           
        }
        #endregion

        #region Update
        
        #endregion

        #region Draw
          public void Draw(GameTime gamTime);
        {
            this.game.
        }
        #endregion

    }
}
