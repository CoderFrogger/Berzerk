using System.Windows.Input;

namespace Berzerk{
class GameRules {
        private List<Enemy> enemies;
        private Player player;
        private Maze maze;

        public bool gameOver = false;

        public GameRules(Maze maze, Player player, List<Enemy> enemies) {
            this.maze = maze;
            this.player = player;
            this.enemies = enemies;
        }

        public bool hitWall(Enemy enemy){
            return maze.isWall();
        }

        public bool hitWall(Player player){
            return maze.isWall();
        }

        public void moveElements() {
            foreach (Enemy enemy in enemies) {
                if (true) gameOver = true;
            }
        }
    }
}