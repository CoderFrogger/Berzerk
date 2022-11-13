using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Berzerk{
    class Player{
        private int delay = 0;
        public List<Bullet> bullets = new List<Bullet>();
        private Sprite sprite;
        public const float PLAYER_SPEED = 4f;
        Vector2f position;

        public Player(){
            sprite = new Sprite();
            sprite.Texture = TextureRender.PlayerTexture;
        }

        public void update() {
            this.userInput();
            this.sprite.Position = position;
        }

        public void draw(RenderTarget window) {
            window.Draw(this.sprite);
        }

        public void userInput() {
            bool moveUp = Keyboard.IsKeyPressed(Keyboard.Key.W);
            bool moveLeft = Keyboard.IsKeyPressed(Keyboard.Key.A);
            bool moveDown = Keyboard.IsKeyPressed(Keyboard.Key.S);
            bool moveRight = Keyboard.IsKeyPressed(Keyboard.Key.D);

            bool isMove = moveUp || moveDown || moveLeft || moveRight;

            if (isMove) {
                if (moveUp) position.Y -= PLAYER_SPEED;
                if (moveDown) position.Y += PLAYER_SPEED;
                if (moveRight) position.X += PLAYER_SPEED;
                if (moveLeft) position.X -= PLAYER_SPEED;
            }

            bool isFired = Keyboard.IsKeyPressed(Keyboard.Key.Space);
            if (isFired) this.fire();
        }

        private void fire(){ //TODO: directional firing
            this.delay++;
            if(this.delay >= 15){
                this.bullets.Add(new Bullet(this.position));
                this.delay = 0;
            }
        }
    }
}