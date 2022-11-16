
using SFML.Graphics;
using SFML.System;

namespace Berzerk{
	class Enemy {
		private readonly Random random = new Random();
		private Sprite sprite;
		public Sprite EnemySprite {get {return sprite;} }
		public const float ENEMY_SPEED = 5f;
		Vector2f position;
		public Vector2f Position { get { return position; } }

		public Enemy() {
			this.sprite = new Sprite();
			this.sprite.Texture = TextureRender.EnemyTexture;
			this.position.X = (float)this.random.Next(30, 1000);
			this.position.Y = (float)this.random.Next(30, 620);
			this.sprite.Position = this.position;
		}

		public void update() { //TODO: Figure out how to wander
			Random rand = new Random();
			int num = rand.Next(0, 8);

			if (num==0)
				this.position.Y -= ENEMY_SPEED;
			if (num==1){
				this.position.Y -= ENEMY_SPEED;
				this.position.X += ENEMY_SPEED;
			}
			if (num==2)
				this.position.X += ENEMY_SPEED;
			if (num==3){
				this.position.Y += ENEMY_SPEED;
				this.position.X += ENEMY_SPEED;
			}
			if (num==4)
				this.position.Y += ENEMY_SPEED;
			if (num==5){
				this.position.Y += ENEMY_SPEED;
				this.position.X -= ENEMY_SPEED;
			}
			if (num==6)
				this.position.X -= ENEMY_SPEED;
			if (num==7){
				this.position.Y -= ENEMY_SPEED;
				this.position.X -= ENEMY_SPEED;
			}
		}

		public void draw(RenderTarget window){
			window.Draw(this.sprite);
		}

	}
}