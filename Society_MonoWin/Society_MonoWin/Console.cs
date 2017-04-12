using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Society_MonoWin
{
    class GameConsole
    {
        SpriteFont Font;
        List<string> Output;
        public bool Active;
        public int Width;
        public int Height;

        public void Initialize(SpriteFont font)
        {
            Font = font;
            Output = new List<string>();
            Active = true;
        }

        public void WriteLine(string text)
        {
            Output.Add(text);
        }

        public void Clear()
        {
            Output.Clear();
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Vector2 Space = new Vector2(0, 20);
            for (int i = 0; i < Output.Count; i++)
            {
                spriteBatch.DrawString(Font, Output[i], position + Space * i, Color.Black);
            }
        }
    }
}
