using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class EnemyManager{
        public List<Enemy> enemies = new List<Enemy>();
        private int enemyCount = 5;


        public void update(Player player){
            for (int i = 0; i <enemyCount; i++){
                enemies.Add(new Enemy());
            }

            for (int i = 0; i <enemyCount; i++){
                if (this.isDead(enemies[i], player)) {
                    enemies.Remove(enemies[i]);
                    enemyCount--;
                }
            }
        }

        public bool isDead(Enemy enemy, Player player){
            //if (player.PlayerSprite.GetGlobalBounds().Intersects(enemy.EnemySprite.GetGlobalBounds())) return false; //TODO: toss it to the player death
            //TODO: add hitting walls and dying

            for (int i = 0; i < player.bullets.Count; i++){
                if (enemy.EnemySprite.GetGlobalBounds().Intersects(player.bullets[i].RectangleBullet.GetGlobalBounds())){
                    player.bullets.Remove(player.bullets[i]);
                    return true;
                }
            }
            return false;
        }

        public void draw(RenderTarget window){
            for (int i = 0; i < enemyCount; i++){
                enemies[i].draw(window);
            }
        }

        internal void update()
        {
            throw new NotImplementedException();
        }
    }
}