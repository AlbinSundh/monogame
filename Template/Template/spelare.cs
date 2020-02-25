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
        Vector2 position;
        Texture2D plan;
        float fart = 10;
        public Spelare(Texture2D texture)
        {
            plan = texture;
            position = new Vector2(350,350); 
        } 
        
        private void Move() {
            KeyboardState kstate = Keyboard.GetState();
            if(kstate.IsKeyDown (Keys.Right))
            {
                position.X += fart;  
            }
            if(kstate.IsKeyDown(Keys.Left ))
            {
                position.X -= fart;
            }

            if (position.X < -100)
                position.X = 800;

            if (position.X > 800)
                position.X = -100;
        }

        public void Update()
        {
            Move();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(plan, position, Color.White);
        }

        public void Skjuta()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Space))
            {
                
            }
        }
    }
}
