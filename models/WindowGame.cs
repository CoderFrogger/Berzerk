using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public abstract class WindowGame{
    Player player;
    List<Enemy> enemies;
    Maze maze;
    GameRules rules;

    public const int TARGET_FPS = 60;
    public const float TIME_UNTIL_UPDATE = 1f/TARGET_FPS;

    public RenderWindow Window {}
}