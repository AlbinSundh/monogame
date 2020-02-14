using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Spelare
    {
        Vector2 positon;
        Texture2D plan;
        float fart = 10;
        public Spelare(Texture2D texture)
        {
            plan = texture;
            positon = new Vector2(400,240); 
        } 
        
        private void Move() {
            KeyboardState kstate = Keyboard.GetState();
            if(kstate.IsKeyDown (Keys.Right))
            {
                positon.X += fart;  
            }
            if(kstate.IsKeyDown(Keys.Left ))
            {
                positon.X -= fart;
            }
        }

        public void Update()
        {
            Move();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(plan, positon, Color.White);
        }
    }
}
