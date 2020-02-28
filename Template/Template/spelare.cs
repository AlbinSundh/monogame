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
        Texture2D kula;
        float fart = 10;
        List<Kula> kullista = new List<Kula>();
        public List<Kula> Kullista
        {
            get
            {
                return kullista;
            }
        }
        public Spelare(Texture2D spelarTexture, Texture2D kulaTexture)
        {
            plan = spelarTexture;
            kula = kulaTexture;
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
            Skjuta();
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
                kullista.Add(new Kula(kula, position));
                
            }
        }
    }
}
