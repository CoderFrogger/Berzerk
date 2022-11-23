using System;
using SFML.Graphics;
using SFML.Window;

namespace Berzerk{
    class TextureRender{
        private static string ASSETS_PATH = "bin/Textures/";
        static Texture playerTexture;
        static Texture enemyTexture;

        public static Texture PlayerTexture { get { return playerTexture; } }
        public static Texture EnemyTexture { get { return enemyTexture; } }

        public static void LoadTextures(){
            playerTexture = new Texture(ASSETS_PATH + "player.png");
            enemyTexture = new Texture(ASSETS_PATH + "enemy.png");
        }
    }
}