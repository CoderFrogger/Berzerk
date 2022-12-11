using SFML.Graphics;
using SFML.System;

namespace Berzerk
{
    public class Object
    {
        public RectangleShape rectangle;
        public Vector2f size;
        public Vector2f position;
        public Vector2f Position {get {return position;}}
        public RectangleShape RectangleShape {get {return this.rectangle;}}
    }
}