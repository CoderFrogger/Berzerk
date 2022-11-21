using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class Bullet{
        private RectangleShape rectangle;
        public const float BULLET_SPEED = 20f;
        Vector2f position;

        Vector2f size = new Vector2f(5, 10);

        public Vector2f Position {get {return position;}}
        public RectangleShape RectangleBullet {get {return this.rectangle;}}

        public Bullet (Vector2f position){
            this.rectangle = new RectangleShape(size);
            this.rectangle.FillColor = Color.Red;
            this.rectangle.Position = position;
            this.position = position;
        }

        public void update(int direction) {

            if(direction==1) this.position.Y -= BULLET_SPEED;
            if(direction==2) this.position.Y += BULLET_SPEED;
            if(direction==3) this.position.X += BULLET_SPEED;
            if(direction==4) this.position.X -= BULLET_SPEED;

            this.rectangle.Position = this.position;
        }
    }
}