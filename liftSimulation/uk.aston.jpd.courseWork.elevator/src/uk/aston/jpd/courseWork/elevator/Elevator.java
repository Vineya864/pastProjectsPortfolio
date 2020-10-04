package uk.aston.jpd.courseWork.elevator;

import java.util.ArrayList;

public class Elevator {
	// variables
	private ArrayList<People> people;
	private int calledTo;
	private int currentFloor;
	//private boolean inMotion;
	private int maxPeople;
	private boolean called;
	private int currentPeople;
	private int destination;
	private boolean doorsOpen;
	private int nextFloorIndex;
	private Building build;
	private boolean waiting;

	// constructor
	public Elevator(int max) {
		this.currentFloor = 0;
		this.waiting=false;
		//this.inMotion = false;
		this.maxPeople = max;
		this.called = false;
		this.currentPeople = 0;
		this.destination = 0;
		this.doorsOpen = false;

		//this.additionalStop=0;
		people = new ArrayList<People>(); //when we have the people class this will instead be an array of people elements
		calledTo= 0;
	}
	public void setBuild(Building build) {
		this.build=build;
	}

	// access
	public int getFloor() {
		return currentFloor;
	}
public int getMax() {
	return maxPeople;
}
	public boolean getCalled() {
		return called;
	}

	public int getDestination() {
		return destination;
	}

	public int checkSpace() {
		return (maxPeople - currentPeople);
	}
	

	/** open the doors */
	private void openDoors() {
		
		//inMotion=false;
		doorsOpen = true;
		System.out.println("doors open");
		waiting=true;
	
		}
	
/** close the doors*/
	private void closeDoors() {
		
		doorsOpen = false;
		System.out.println("doors shut");
		
		//inMotion=true;
	}

	/** and a person to the lift */
	public void addStops(People newPerson) {
		//additionalStop=stop;
		people.add(newPerson);//will be person.destitiation()
		currentPeople = currentPeople + newPerson.getWeight();//will be currentPeople + person.weight()
		//System.out.println(stops);
	}

/** remove the last person to get out the lift */
	public void removeStops(String name) {
		
		for (int i=0;i<people.size();i++) {
			if (people.get(i).getName().contentEquals(name)){
				currentPeople=currentPeople-people.get(i).getWeight();
				
				people.remove(i);
			}
		
		}
		}
		

	/** what is the next closest floor */
	public void calculateDestination(boolean direction) {
	
		if (currentPeople == 0 && !called) {
			reset();
		} else {
			int distanceToFloor = 10;
			int nextFloor = 0;
			 nextFloorIndex = 0;
			
			if (direction) {

				for (int i = 0; i < people.size(); i++) {
					if ((people.get(i).getDestination().getFloorNum() - getFloor()) < distanceToFloor) {
						distanceToFloor = people.get(i).getDestination().getFloorNum() - getFloor();
						nextFloor = people.get(i).getDestination().getFloorNum();
						 nextFloorIndex = i;
					}
				}
				destination = nextFloor;				
			} else {// if going down

				for (int i = 0; people.size() > 0 && i < people.size(); i++) {
					if ((getFloor() - people.get(i).getCurrentFloor().getFloorNum()) > distanceToFloor) {
						distanceToFloor = getFloor() - people.get(i).getCurrentFloor().getFloorNum();
						nextFloor = people.get(i).getCurrentFloor().getFloorNum();
						System.out.println(getFloor() - people.get(i).getCurrentFloor().getFloorNum());
						 nextFloorIndex = i;
					}
				}
				destination = nextFloor;
				
			}
		}
		if (calledTo != -1) {
			destination=calledTo;
		}
	
	}

	
	private void updatePeople() {
		
		for (int i=0;i<people.size();i++) {
			people.get(i).setCurrentFloor(build.getFloors().get(currentFloor));///to what floor the lift is on
		}
	}
	
	
	/** move to the next floor */
	private void move() {
		
	if(!waiting){
		
		
		if (currentFloor < destination) {  
			closeDoors();
			currentFloor++;
			System.out.println(currentFloor);
		
		}
		if (currentFloor > destination) { 
			closeDoors();
			currentFloor--;
			System.out.println(currentFloor);
		}
	
	
	
	
		
	}
	else{
		waiting=false;
		closeDoors();
	}
		
		updatePeople();
	
	}


/** go back to the ground floor*/
	private void reset() {
		if (destination!=0) {
		destination = 0;
		System.out.println("Reset called");
		}

	}

	public void called(int floor) {
		called = true;
		calledTo=floor;
		
	}
	
	public String toString() {
		return("lift is on floor:"+ currentFloor+ " With "+people.size() +" People Inside \n going to floor "+ destination);
	}

	
	
	
	
	public void tick() {
		
		if (currentFloor==destination) {
			openDoors();
			
		}
		if (currentFloor==0) {
			this.calculateDestination(true);
		}
		else if((!called)&&currentPeople==0) {
			closeDoors();
			this.calculateDestination(false);
			
			
			}
	
		
		
	else {
		
			closeDoors();
			
			
	boolean tempDirection;
	int tempNum=0;
			for(int index=0;index<people.size();index++) {
				if (people.get(index).getDestination().getFloorNum() > currentFloor) {
					tempNum++;
				}
			}
			if(tempNum>=people.size()) {
				tempDirection=true;
			}else {
				tempDirection=false;
			
			}	
			calculateDestination(tempDirection); 
			
		
	}
	

	if(currentFloor==calledTo) {
		calledTo=-1;
	}
	
		move();

	
}
	
	
}
	
	
	
	

// may need to change how move works so that it will be unstead called as part of the tick.