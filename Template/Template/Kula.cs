using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Kula
    {
        Texture2D kulbild;
        float fart = 10;
        Vector2 position = new Vector2();
        
        public Kula(Texture2D texture, Vector2 startPosition)
        {
            kulbild = texture;
            position = startPosition;
        }

        public void Update()
        {
            Move();
        }

        public void Move()
        {
            position.Y -=fart;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(kulbild, position, Color.White);
        }
    }
}
