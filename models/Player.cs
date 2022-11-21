using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Berzerk{
    class Player{
        private int delay = 0;
        public List<Bullet> bullets = new List<Bullet>();
        private Sprite sprite;
        public Sprite PlayerSprite {get {return sprite;} }
        public const float PLAYER_SPEED = 4f;
        Vector2f position;
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
                this.bullets[i].update(direction);
                if (this.bullets[i].Position.Y < 0) this.bullets.Remove(this.bullets[i]);
            }
        }

        public void draw(RenderTarget window) {
            window.Draw(this.sprite);
            foreach (var bullet in this.bullets) window.Draw(bullet.RectangleBullet);
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

        private void fire(){ //TODO: directional firing
            this.delay++;
            if(this.delay >= 10){
                this.bullets.Add(new Bullet(this.position));
                this.delay = 0;
            }
        }

        public bool isDead(Enemy enemy, Player player){
            if (player.PlayerSprite.GetGlobalBounds().Intersects(enemy.EnemySprite.GetGlobalBounds())) return true;
            else return false;
        }
    }
}