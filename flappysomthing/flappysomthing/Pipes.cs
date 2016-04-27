using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace flappysomthing {
    class Pipes {
        public Vector2 position, velocity;
        public Texture2D sprite;
        public Rectangle hitbox;

        public void Initialize() {
            position.X = 800;
            position.Y = 300;
            velocity.X = -3.1f;
        }

        public void Update() {
            position += velocity;
        }
    }
}
