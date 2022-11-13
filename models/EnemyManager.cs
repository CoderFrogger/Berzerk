using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class EnemyManager{
        public List<Enemy> enemies = new List<Enemy>();
        private int enemyCount = 5;


        public void generateEnemies(){
            for (int i = 0; i <enemyCount; i++){
                enemies.Add(new Enemy());
            }
        }

        public void draw(RenderTarget window){
            for (int i = 0; i < enemyCount; i++){
                enemies[i].draw(window);
            }
        }
    }
}