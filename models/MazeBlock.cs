using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class MazeBlock : Object{
        
        public MazeBlock(int x, int y, int len, int wid){
            size = new Vector2f(len, wid);
            this.rectangle = new RectangleShape(size);
            this.rectangle.FillColor = Color.Blue;
            this.position.X = x;
			this.position.Y = y;
			this.rectangle.Position = this.position;
        }

        public void draw(RenderTarget window){
			window.Draw(this.rectangle);
		}
    }
}