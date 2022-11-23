using SFML.Graphics;
using SFML.Window;

namespace Berzerk{
    class WindowGame{
        public const int WIDTH = 1280;
        public const int HEIGHT = 720;
        private const string TITLE = "Ye Olde Gungeon";
        private RenderWindow window;
        private VideoMode mode = new VideoMode(WIDTH, HEIGHT);

        Player player;
        EnemyManager enemies;
        Maze maze;

        public WindowGame(){
            this.window = new RenderWindow(this.mode, TITLE);

            this.window.SetVerticalSyncEnabled(true);
            this.window.Closed += (sender, args) => {this.window.Close();};

            TextureRender.LoadTextures();
            player = new Player();
            enemies = new EnemyManager();
            maze = new Maze();
        }

        public void run(){
            while(this.window.IsOpen){
                this.handleEvents();
                this.update();
                this.draw();
            }
        }

        private void handleEvents(){
            this.window.DispatchEvents();
        }

        private void update(){
            this.player.update(this.enemies);
            this.enemies.update(this.player);
            this.maze.update(this.enemies.enemies, this.player, this.enemies.enemyCount);
        }

        private void draw(){
            this.window.Clear(Color.Black);
            this.player.draw(this.window);
            this.enemies.draw(this.window);
            this.maze.draw(this.window);
            this.window.Display();
        }
    }
}