using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class EnemyManager{
        public GameRules rules;
        public List<Enemy> enemies = new List<Enemy>();
        private int enemyCount = 5;


        public void update(Player player){
            for (int i = 0; i <enemyCount; i++){
                enemies.Add(new Enemy());
            }

            for (int i = 0; i <enemyCount; i++){
                if (this.rules.enemyIsDead(enemies[i], player)) enemies.Remove(enemies[i]);
            }
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