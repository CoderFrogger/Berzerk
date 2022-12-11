using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Berzerk
{
    public class Entity{
        public Sprite sprite;
        public Sprite Sprite {get {return sprite;} }
        public Vector2f position;

        public bool isDead(Entity attacker, Entity defender){
            if (attacker.Sprite.GetGlobalBounds().Intersects(defender.Sprite.GetGlobalBounds())) return true;
            else return false;
        }
    }
}