package uk.aston.jpd.courseWork.elevator;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Before;
import org.junit.Test;

import uk.aston.jpd.courseWork.elevator.Maintance;
public class MaintanceTest {
	private People testWorker;
	@Test
	public void setQueueTest() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Button buttonOne= new Button(1);
		Floor floorOne=new Floor(1,buttonOne);
		Button buttonTwo= new Button(2);
		Floor floorTwo=new Floor(2,buttonTwo);
		Button buttonThree= new Button(3);
		Floor floorThree=new Floor(3,buttonThree);
		Button buttonFour= new Button(4);
		Floor floorFour=new Floor(4,buttonFour);
		Button buttonFive= new Button(5);
		Floor floorFive=new Floor(5,buttonFive);
	
		floorList.add(floorTwo);
		floorList.add(floorThree);
		floorList.add(floorFour);
		floorList.add(floorFive);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Maintance(office,"Test",1,0,1);
		floor.addPersonFloor(testWorker);
		testWorker.setCurrentFloor(floor);
		testWorker.setQueue(true);
		assertTrue(testWorker.getQueue());
				
	}
	@Test
	public void scrableChanceTest() {
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		Button button= new Button(0);
		Floor floor=new Floor(0,button);
		floorList.add(floor);
		Button buttonOne= new Button(1);
		Floor floorOne=new Floor(1,buttonOne);
		Button buttonTwo= new Button(2);
		Floor floorTwo=new Floor(2,buttonTwo);
	
		floorList.add(floorTwo);
		
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Maintance(office,"Test",4,0,1);
		assertFalse(0==((Maintance) testWorker).scrableChance());
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
		Button buttonTwo= new Button(2);
		Floor floorTwo=new Floor(2,buttonTwo);
		Button buttonThree= new Button(3);
		Floor floorThree=new Floor(3,buttonThree);
		Button buttonFour= new Button(4);
		Floor floorFour=new Floor(4,buttonFour);
		Button buttonFive= new Button(5);
		Floor floorFive=new Floor(5,buttonFive);
	
		floorList.add(floorTwo);
		floorList.add(floorThree);
		floorList.add(floorFour);
		floorList.add(floorFive);
		Building office = new Building(handle,lift,floorList,null,1,0.001,0.02);
		floor.setBuild(office);
		testWorker=new Maintance(office,"Test",4,0,1);
		floor.addPersonFloor(testWorker);
		People testWorkerOne;
		testWorkerOne=new Client(office,"Testone",1,0,1);
	//	floor.addPersonFloor(testWorkerOne);
//		office.addToBuilding(testWorkerOne);
		testWorker.setCurrentFloor(floorOne);
		testWorker.setQueue(false);
		testWorker.setDestination(floorOne);
		testWorker.tick();
		assertTrue(testWorker.getWorkDone());
		testWorker.setCurrentFloor(floor);
		assertTrue(((Maintance) testWorker).getWorkTicks()==0);
		
	}

}
