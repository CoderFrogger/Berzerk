using SFML.Graphics;
using SFML.System;

namespace Berzerk{
    class Maze{
        
        List<MazeBlock> blocks = new List<MazeBlock>();
        private int[ , ] matrix = {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,1,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            
        };

        public void update(){
            for (int i = 0; i <matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    if(isWall(i, j))
                        blocks.Add(new MazeBlock(j*80, i*80));
                }
            }

            // for (int i = 0; i <enemyCount; i++){
            //     if (this.isDead(enemies[i], player)) {
            //         enemies.Remove(enemies[i]);
            //         enemyCount--;
            //     }

            //     if (player.isDead(enemies[i], player)) {
            //         System.Environment.Exit(0);
            //     }
            // }
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