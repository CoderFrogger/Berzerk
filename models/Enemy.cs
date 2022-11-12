public class Enemy {
	public int x;
	public int y;
	public int dx;
	public int dy;

	public Enemy(int x, int y, int dx, int dy) {
		this.x = x;
		this.y = y;
		this.dx = dx;
		this.dy = dy;

	}

	public void moveDirection() {
		x = x + dx;
		y = y + dy;
	}

	public void changeDirection() {
		int temp = dx;
		dx = -dy;
		dy = temp;
	}

}