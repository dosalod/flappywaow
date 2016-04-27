using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace flappysomthing {
  public class screenManager {
        private screenManager instance;
        public screenManager Instance {
            get {
                if(instance == null) {
                    instance = new screenManager();
                }
                return instance;

               
            }
        }
        public enum state {
            menu, playing, splashscreen,
        }
        public state CurrentScreen;

        public void Initialize() {
            
       
            
        }

        public void Update(GameTime gametime) {
            if(CurrentScreen == state.menu) {
                //osv
            }
        }
        public void Draw(SpriteBatch spritebatch) {
            if(CurrentScreen == state.menu) {
                // Draw menu
            }
            else if(CurrentScreen == state.playing) { 
                // Draw normal screen
            }
            //osv
        }


    }
}