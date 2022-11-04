public class Enemy {
	int x;
	int y;
	int dx;
	int dy;

	public Enemy(int x, int y, int dx, int dy) {
		this.x = 6;
		this.y = 7;
		this.dx = -1;
		this.dy = 0;

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