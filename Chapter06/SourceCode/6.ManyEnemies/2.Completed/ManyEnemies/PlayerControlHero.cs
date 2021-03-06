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

namespace BookExample
{
    /// <summary>
    /// ChaserGameObject class: GameObject capable of chasing after a target
    /// </summary>
    public class PlayerControlHero : GameObject
    {
        public PlayerControlHero(Vector2 position) : 
            base("KidLeft", position, new Vector2(7f, 8f))
        {
        }

        public void UpdateHero()
        {
            Vector2 delta = InputWrapper.ThumbSticks.Left;
            Position += delta;

            if (delta.X > 0)
                mImage = Game1.sContent.Load<Texture2D>("KidRight");
            else
                mImage = Game1.sContent.Load<Texture2D>("KidLeft");
        }
    }
}
