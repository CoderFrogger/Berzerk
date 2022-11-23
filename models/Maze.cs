using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class Maze{
        List<MazeBlock> blocks = new List<MazeBlock>();
        private int[ , ] matrix = {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        };

        public void update(List<Enemy> enemies, Player player, int enemyCount){
            for (int i = 0; i <matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    if(isWall(i, j) && (i==0 || i==matrix.GetLength(0)-1))
                        blocks.Add(new MazeBlock(j*80, i*80, 100, 50));
                    else if(isWall(i, j) && (j==0 || j==matrix.GetLength(1)-1))
                        blocks.Add(new MazeBlock(j*80, i*80, 50, 100));
                }
            }

            for (int i = 0; i <blocks.Count(); i++){
                for (int j = 0; j < enemyCount; j++){
                    if (enemies[j].EnemySprite.GetGlobalBounds().Intersects(blocks[i].RectangleBlock.GetGlobalBounds())) {
                        enemies.Remove(enemies[j]);
                        enemyCount--;
                    }
                }

                if (player.PlayerSprite.GetGlobalBounds().Intersects(blocks[i].RectangleBlock.GetGlobalBounds())) {
                    System.Environment.Exit(0);
                }
            }
        }

        public void draw(RenderTarget window){
            for (int i = 0; i < blocks.Count; i++){
                blocks[i].draw(window);
            }
        }
        
        public bool isWall(int x, int y) {
            if(matrix[x , y]==1) return true;
            return false;
        }
    }
}