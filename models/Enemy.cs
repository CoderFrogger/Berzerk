
using SFML.Graphics;
using SFML.System;

namespace Berzerk{
	class Enemy : Entity{
		private readonly Random random = new Random();
		public const float ENEMY_SPEED = 5f;
		public Vector2f Position { get { return position; } }

		public Enemy() {
			this.sprite = new Sprite();
			this.sprite.Texture = TextureRender.EnemyTexture;
			this.position.X = (float)this.random.Next(50, WindowGame.WIDTH-50);
			this.position.Y = (float)this.random.Next(50, WindowGame.HEIGHT-50);
			this.sprite.Position = this.position;
		}

		public void update() { //:(
			Random rand = new Random();
			int num = rand.Next(0, 4);

			if (num==0)
				this.position.Y -= ENEMY_SPEED;
			if (num==1)
				this.position.X += ENEMY_SPEED;
			if (num==2)
				this.position.Y += ENEMY_SPEED;
			if (num==3)
				this.position.X -= ENEMY_SPEED;

		}

		public void draw(RenderTarget window){
			window.Draw(this.sprite);
		}

	}
}