using System;
using SFML.Graphics;
using SFML.Window;

namespace Berzerk{
    class TextureRender{
        private static string ASSETS_PATH = "bin/Textures/";
        static Texture playerTexture;
        static Texture enemyTexture;
        static Texture mazeTexture;

        public static Texture PlayerTexture { get { return playerTexture; } }
        public static Texture EnemyTexture { get { return enemyTexture; } }
        public static Texture MazeTexture { get { return mazeTexture; } }

        public static void LoadTextures(){
            playerTexture = new Texture(ASSETS_PATH + "player.png");
            enemyTexture = new Texture(ASSETS_PATH + "enemy.png");
            mazeTexture = new Texture(ASSETS_PATH + "maze.png");
        }
    }
}