using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class MazeBlock{
        
        private Sprite sprite;
        Vector2f position;
		public Vector2f Position { get { return position; } }
        
        public MazeBlock(int x, int y){
            sprite = new Sprite();
            sprite.Texture = TextureRender.MazeTexture;
            this.position.X = x;
			this.position.Y = y;
			this.sprite.Position = this.position;
        }

        public void draw(RenderTarget window){
			window.Draw(this.sprite);
		}
    }
}