// public class Renderer{
//     private List<Enemy> enemies;
//     private Player player;
//     private Maze maze;

//     public Renderer(Player player, Maze maze, List<Enemy> enemies){
//     this.player = player;
//     this.maze = maze;
//     this.enemies = enemies;
//     }

//     public void renderGame() {
//     for (int y=0; y<maze.getHeight(); y++) {
//             for (int x=0; x<maze.getWidth(); x++) {

//                 if (y == player.y && x == player.x)
//                     Console.Write("C");

//                 else if (isEnemy(x, y))
//                     Console.Write("@");

//                 else if (maze.isWall(x, y))
//                     Console.Write("#");

//                 else
//                     Console.Write(" ");
//             }
//             Console.WriteLine();
//         }
//     }

//     private bool isEnemy(int x, int y) {
//         foreach (Enemy enemy in enemies) {
//             if (enemy.x == x && enemy.y == y)
//             return true;
//         }
//         return false;
//     }
    
// }