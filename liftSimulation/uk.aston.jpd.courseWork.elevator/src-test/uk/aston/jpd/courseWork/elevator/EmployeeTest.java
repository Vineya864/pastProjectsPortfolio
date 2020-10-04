package uk.aston.jpd.courseWork.elevator;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Before;
import org.junit.Test;

import uk.aston.jpd.courseWork.elevator.Employee;
public class EmployeeTest {
	private People testWorker;
	
	@Test
	public void complainTest() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(testWorker);
		testWorker.setCurrentFloor(floor);
				
		testWorker.complian(0);
		assertEquals(office.complaintNumber,0);
		testWorker.complian(60);
		assertEquals(office.complaintNumber,0);
		testWorker.complian(61);
		assertEquals(office.complaintNumber,1);
		
	}
	@Test
	public void setQueueTest() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(testWorker);
		testWorker.setCurrentFloor(floor);
		testWorker.setQueue(true);
		assertTrue(testWorker.getQueue());
				
	}
	@Test
	public void tickTest() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Button buttonOne= new Button(1);
		Floor floorOne=new Floor(1,buttonOne);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(testWorker);
		testWorker.setCurrentFloor(floor);
		testWorker.setQueue(false);
		testWorker.setDestination(floorOne);
		testWorker.tick();
		assertTrue(testWorker.getInLift());
		assertTrue(button.isPressed());
	}
	
	

}
