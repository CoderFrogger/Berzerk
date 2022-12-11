using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Berzerk
{
    public class Entity{
        private Sprite sprite;
        public Sprite Sprite {get {return sprite;} }
        Vector2f position;

        public bool isDead(Entity entity2, Entity entity1){
            if (entity2.Sprite.GetGlobalBounds().Intersects(entity1.Sprite.GetGlobalBounds())) return true;
            else return false;
        }
    }
}