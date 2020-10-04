package uk.aston.jpd.courseWork.elevator;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Before;
import org.junit.Test;

import uk.aston.jpd.courseWork.elevator.Floor;
public class FloorTest {
	private Floor floor;
	private People samplePerson;

	public void setUp() throws IOException {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		samplePerson=new Employee(office,"Test",1,0,5);
		
		floor.addPersonFloor(samplePerson);
		samplePerson.setCurrentFloor(floor);
		System.out.println(floor.getAllPeople().size());
	}
	
	@Test
	public void personIsRemoved() { 
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		samplePerson=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(samplePerson);
		samplePerson.setCurrentFloor(floor);
		
		int startingSize=floor.getAllPeople().size();
		floor.removePersonFloor(samplePerson);
		assertEquals(startingSize-1,floor.getAllPeople().size());
		
	}
	@Test
	public void personIsAdded() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		samplePerson=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(samplePerson);
		samplePerson.setCurrentFloor(floor);
		
		People samplePersonOne;
		int startingSize=floor.getAllPeople().size();
		samplePersonOne=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(samplePersonOne);
		assertEquals(startingSize+1,floor.getAllPeople().size());
		
	}

	
	@Test
	public void personIsMoved() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		samplePerson=new Employee(office,"Test",1,0,5);
		floor.addPersonFloor(samplePerson);
		samplePerson.setCurrentFloor(floor);
		floor.addPersonQueue(samplePerson);
		int startingSize=floor.getAllPeople().size();
		int queueSize=floor.getQueue().size();
		floor.moveToLift();
		
		assertEquals(startingSize-1,floor.getAllPeople().size());
		assertEquals(queueSize-1,floor.getQueue().size());
	}
	
	
}
