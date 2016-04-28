using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace flappysomthing {
    class Bird {
        Vector2 position, velocity;
        bool isAlive;
        Texture2D sprite;
        Rectangle hitbox;

        public void Update() {
            position += velocity;
        }
    }
}
