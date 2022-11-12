using System;

public class Main {
    public static void main(string[] args) {

        Player player = new Player(5,5);

        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(new Enemy(6, 7, -1, 0));
		enemies.Add(new Enemy(10, 17, 0, 1));

        Maze maze = new Maze();

        Renderer renderer = new Renderer(player, maze, enemies);
		GameRules rules   = new GameRules(maze, player, enemies);

        while(rules.gameOver == false) {
		
			renderer.renderGame();
			
			byte userInput = readUserInput();
			
			rules.userInput(userInput);
			
			rules.moveElements();
		}
    }

    private static byte readUserInput() {
		byte[] bytes = new byte[10];
		Console.ReadLine();
		byte userInput = bytes[0];
		return userInput;
	}
}