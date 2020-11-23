package uk.aston.jpd.courseWork.elevator;

public class Button {
	private int floor;
	private boolean pressed;
	public Button(int floor) {
		this.floor=floor;
		pressed=false;
	}
	public int getFloor() {
		return floor;
	}
	public  boolean isPressed() {
		return this.pressed;
	}
	/**set the state of the button
	*@param boolean pressed State
	*/
	public void setPressed(boolean pressed) {
		this.pressed = pressed;
	}
	
	
	
	
	
	
	public void tick(Building build) {
		if (pressed) {
			//setPressed(false);
		build.getHandle().callElevator(build.getElevator(),floor);
		
	}
		if(build.getElevator().getFloor()==floor) {
			setPressed(false);
		
		}
}
}