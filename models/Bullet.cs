using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class Bullet : Object{
        public const float BULLET_SPEED = 20f;
        private int direction;

        public Bullet (Vector2f position, int direct){
            size = new Vector2f(10, 10);
            direction = direct;
            this.rectangle = new RectangleShape(size);
            this.rectangle.FillColor = Color.Red;
            this.rectangle.Position = position;
            this.position = position;
        }

        public void update() {

            if(direction==1) this.position.Y -= BULLET_SPEED;
            if(direction==2) this.position.Y += BULLET_SPEED;
            if(direction==3 || direction==0) this.position.X += BULLET_SPEED;
            if(direction==4) this.position.X -= BULLET_SPEED;

            this.rectangle.Position = this.position;
        }

        public bool isGone(float Y, float X){
            if (Y < 0 || Y > WindowGame.HEIGHT || X < 0 || X > WindowGame.WIDTH) return true;
            else return false;
        }
    }
}