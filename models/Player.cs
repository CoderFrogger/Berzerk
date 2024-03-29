using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Berzerk{
    class Player : Entity{
        private int delay = 0;
        public List<Bullet> bullets = new List<Bullet>();
        public const float PLAYER_SPEED = 4f;
        private int direction;

        public Player(){
            sprite = new Sprite();
            sprite.Texture = TextureRender.PlayerTexture;
            this.position.X = 75;
            this.position.Y = WindowGame.HEIGHT/2;
        }

        public void update(EnemyManager enemies) {
            this.userInput();
            this.sprite.Position = position;

            for (int i = 0; i < this.bullets.Count; i++){
                this.bullets[i].update();
                if (bullets[i].isGone(this.bullets[i].Position.Y, this.bullets[i].Position.X)) this.bullets.Remove(this.bullets[i]);
            }
        }

        public void draw(RenderTarget window) {
            window.Draw(this.sprite);
            foreach (var bullet in this.bullets) window.Draw(bullet.RectangleShape);
        }

        public void userInput() {
            bool moveUp = Keyboard.IsKeyPressed(Keyboard.Key.W);
            bool moveLeft = Keyboard.IsKeyPressed(Keyboard.Key.A);
            bool moveDown = Keyboard.IsKeyPressed(Keyboard.Key.S);
            bool moveRight = Keyboard.IsKeyPressed(Keyboard.Key.D);

            bool isMove = moveUp || moveDown || moveLeft || moveRight;

            if (isMove) {
                if (moveUp) {position.Y -= PLAYER_SPEED;direction=1;}
                if (moveDown) {position.Y += PLAYER_SPEED;direction=2;}
                if (moveRight) {position.X += PLAYER_SPEED;direction=3;}
                if (moveLeft) {position.X -= PLAYER_SPEED;direction=4;}
            }

            bool isFired = Keyboard.IsKeyPressed(Keyboard.Key.Space);
            if (isFired) this.fire();
        }

        private void fire(){
            this.delay++;
            if(this.delay >= 10){
                this.bullets.Add(new Bullet(this.position, direction));
                this.delay = 0;
            }
        }
    }
}