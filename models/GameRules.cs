using SFML.Graphics;

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

        public bool enemyIsDead(Enemy enemy, Player player){
            if (player.PlayerSprite.GetGlobalBounds().Intersects(enemy.EnemySprite.GetGlobalBounds())) return false; //TODO: toss it to the player death

            for (int i = 0; i < player.bullets.Count; i++){
                if (enemy.EnemySprite.GetGlobalBounds().Intersects(player.bullets[i].RectangleBullet.GetGlobalBounds())){
                    player.bullets.Remove(player.bullets[i]);
                    return true;
                }
            }
            return false;
        }
    }
}