using SFML.Graphics;
using SFML.Window;

class WindowGame{
    private const int WIDTH = 640;
    private const int HEIGHT = 480;
    private const string TITLE = "Ye Olde Gungeon";
    private RenderWindow window;
    private VideoMode mode = new VideoMode(WIDTH, HEIGHT);

    public WindowGame(){
        this.window = new RenderWindow(this.mode, TITLE);

        this.window.SetVerticalSyncEnabled(true);
        this.window.Closed += (sender, args) => {this.window.Close();};

        TextureRender.LoadTextures();
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

    private void update(){}

    private void draw(){
        this.window.Clear(Color.Black);
        this.window.Display();
    }
}