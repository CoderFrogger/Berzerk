using SFML.Graphics;
using SFML.System;
using System.Windows.Input;

public class Player{
    private Sprite sprite;
    public const float PLAYER_SPEED = 4f;
    Vector2f position;

    public Player(){
        sprite = new Sprite();
        sprite.Texture = TextureRender.PlayerTexture;
    }

    public void update() {}

    public void draw(RenderTarget window) {
        window.Draw(this.sprite);
    }

    public void userInput() {
        bool moveUp = Keyboard.IsKeyDown(Key.W);
        bool moveLeft = Keyboard.IsKeyDown(Key.A);
        bool moveDown = Keyboard.IsKeyDown(Key.S);
        bool moveRight = Keyboard.IsKeyDown(Key.D);
    }
}