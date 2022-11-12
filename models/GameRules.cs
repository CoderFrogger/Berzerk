public class GameRules {

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
        return maze.isWall(enemy.x + enemy.dx, enemy.y + enemy.dy);
    }

    public bool hitWall(Player player){
        return maze.isWall(player.x, player.y);
    }

    public void moveElements() {
        foreach (Enemy enemy in enemies) {
            if (player.x == enemy.x && player.y == enemy.y) gameOver = true;
        }
    }

    public void userInput(int input) {
        switch (input) {
            case 'q':
                gameOver = true;
                break;
            case 'a':
                player.x--;
                break;
            case 'd':
                player.x++;
                break;
            case 'w':
                player.y--;
                break;
            case 's':
                player.y++;
                break;
        }
        if (hitWall(player)) gameOver = true;
    }
}