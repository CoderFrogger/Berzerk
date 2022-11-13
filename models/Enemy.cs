
using SFML.Graphics;
using SFML.System;

namespace Berzerk{
	class Enemy {
		private readonly Random random = new Random();
		private Sprite sprite;
		public const float ENEMY_SPEED = 5f;
		Vector2f position;
		public Vector2f Position { get { return position; } }

		public Enemy() {
			this.sprite = new Sprite();
			this.sprite.Texture = TextureRender.EnemyTexture;
			this.position.X = (float)this.random.Next(5, 1000);
			this.position.Y = (float)this.random.Next(5, 620);
			this.sprite.Position = this.position;
		}

		public void update() {
			Random rand = new Random();
			switch (rand.Next(0, 8)){
				case 0:
					this.position.Y -= ENEMY_SPEED;
					break;
				case 1:
					this.position.Y -= ENEMY_SPEED;
					this.position.X += ENEMY_SPEED;
					break;
				case 2:
					this.position.X += ENEMY_SPEED;
					break;
				case 3:
					this.position.Y += ENEMY_SPEED;
					this.position.X += ENEMY_SPEED;
					break;
				case 4:
					this.position.Y += ENEMY_SPEED;
					break;
				case 5:
					this.position.Y += ENEMY_SPEED;
					this.position.X -= ENEMY_SPEED;
					break;
				case 6:
					this.position.X -= ENEMY_SPEED;
					break;
				case 7:
					this.position.Y -= ENEMY_SPEED;
					this.position.X -= ENEMY_SPEED;
					break;
			}
		}

		public void draw(RenderTarget window){
			window.Draw(this.sprite);
		}

	}
}