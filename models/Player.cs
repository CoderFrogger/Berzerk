using SFML.Graphics;
using SFML.System;

public class Player{
    public int x;
    public int y;

    private Sprite sprite;

    public Player(int x, int y){
        sprite = new Sprite();
        sprite.Texture = TextureRender.PlayerTexture;

        this.x = x;
        this.y = y;
    }

    public void update() {}

    public void draw(RenderTarget window) {
        window.Draw(this.sprite);
    }
}