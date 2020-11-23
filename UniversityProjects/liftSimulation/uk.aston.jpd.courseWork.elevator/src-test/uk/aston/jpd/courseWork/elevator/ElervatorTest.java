package uk.aston.jpd.courseWork.elevator;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import org.junit.Before;
import org.junit.Test;

public class ElervatorTest {
	@Test
	public void moveTest() {
		List<Floor> floorList=new ArrayList<Floor>();
		for (int i=0; i<7;i++) {
			Button button= new Button(i);
			Floor temp=new Floor(i,button);	
			
			floorList.add(temp);
		}
		List<People>allPeople=new ArrayList<People>();
		Elevator lift=new Elevator(4);
		ElevatorHandler handle = new ElevatorHandler();
		Building office = new Building(handle,lift,floorList,allPeople,1,0.001,0.02);
		lift.setBuild(office);
		//create employees and add them to the floor
		int eNumber=3;
		for(int i=0;i<eNumber;i++) {
			People employee =new Employee(office,"E"+i,1,0,6);
			floorList.get(0).addPersonFloor(employee);
		}
		//set the floors to the building
		for(Floor F: floorList) {
			F.setBuild(office);
		}
		//add the employees to the building
		for(int i=0;i<eNumber;i++) {
			
			office.addToBuilding(floorList.get(0).getPerson(i));
		}
		floorList.get(0).getAllPeople().get(0).setCurrentFloor(office.getFloors().get(0));
		floorList.get(0).getAllPeople().get(0).setDestination(office.getFloors().get(4));
		lift.addStops(floorList.get(0).getAllPeople().get(0));
		lift.calculateDestination(true);
		int num=lift.getFloor();
		floorList.get(0).getAllPeople().get(0).tick();
		floorList.get(0).getAllPeople().get(0).tick();
		lift.tick();		
		lift.tick();		
		assertFalse(num==lift.getFloor());
		
		assertTrue(lift.toString().equals("lift is on floor:"+ 1+ " With "+2 +" People Inside \n going to floor "+ 4));
	
}
	
	@Test
	public void resetTest() {
		List<Floor> floorList=new ArrayList<Floor>();
		for (int i=0; i<7;i++) {
			Button button= new Button(i);
			Floor temp=new Floor(i,button);	
			
			floorList.add(temp);
		}
		List<People>allPeople=new ArrayList<People>();
		Elevator lift=new Elevator(4);
		ElevatorHandler handle = new ElevatorHandler();
		Building office = new Building(handle,lift,floorList,allPeople,1,0.001,0.02);
		lift.setBuild(office);
		//create employees and add them to the floor
		int eNumber=3;
		for(int i=0;i<eNumber;i++) {
			People employee =new Employee(office,"E"+i,1,0,6);
			floorList.get(0).addPersonFloor(employee);
		}
		//set the floors to the building
		for(Floor F: floorList) {
			F.setBuild(office);
		}
		//add the employees to the building
		for(int i=0;i<eNumber;i++) {
			
			office.addToBuilding(floorList.get(0).getPerson(i));
		}

		lift.tick();
		assertTrue(lift.getDestination()==0);
		
	}
}
