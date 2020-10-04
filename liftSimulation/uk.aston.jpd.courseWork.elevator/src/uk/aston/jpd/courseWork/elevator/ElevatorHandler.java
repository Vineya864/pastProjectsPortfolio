package uk.aston.jpd.courseWork.elevator;
/**
 * 
 * @author aj-vi
 *
 */
public class ElevatorHandler {
	public ElevatorHandler() {

	}
/**  add a person to the lift
 * @param person the person being added
 * @param build the building in question
 * */
	public boolean addPerson(People person, Building build ) {
		if (build.getElevator().checkSpace() < person.getWeight()) {
			System.out.println("lift full");
			return false;
		} else {
		
			build.getElevator().addStops(person);
			return true;
		}

	}
/** call the elevator to the required floor
 * @param lift the Elevator
 * @param the floor number as an int
 * */
	public void callElevator(Elevator lift, int floor) {
	
		if (lift.checkSpace() == 0) {
			System.out.println("no room in lift");
		}else {
			lift.called(floor);
		}

	}

}
