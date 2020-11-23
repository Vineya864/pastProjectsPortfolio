package uk.aston.jpd.courseWork.elevator;

public abstract class People {
	private   String name;
	private  int weight ;
	private  int minFloor ;
	private   int maxFloor;
	private Floor destination;
	private Floor currentFloor;
	private Building build;
	private boolean inLift;
	private boolean inQueue;
	private boolean complained;
	private int waitingTime;
	private int averageTime;
	
	/** the abstract class for all the people in the building*/
	public People(Building build,String name, int weight, int minFloor, int maxFloor) {
		this.name =name;
		this.build=build;
		this.weight =weight;
		this.minFloor =minFloor;
		this.maxFloor= maxFloor;
		this.destination=build.getFloors().get(0);
		this.currentFloor=build.getFloors().get(0);
		this.inLift=false;
		this.inQueue=false;
		this.complained=false;
		waitingTime=0;
		averageTime=0;
		
	}
	/** get the building the person is in*/
	public Building getBuild() {
		return build;
	}
	/**check time and lodge complaint
	 * @param time Int the waiting time
	 * */
	public void complian(int time) {
		if ((!complained) &&time>60) {
			build.addComplaintNumber();
			complained=true;
		}
	}
	/** new destination
	 * @param Floor floor */
	public void setDestination(Floor floor) {
		this.destination=floor;
	}
	/** on a new floor */
	public void setCurrentFloor(Floor currentFloor) {
		this.currentFloor=currentFloor;
		}
	/** enter the lift*/
	public void enterLift() {
		inLift=true;
	}
	/** leave the lift*/
	public void leaveLift() {
		inLift=false;
	}
	/** enter the queue*/
	public void inQueue() {
		inQueue=true;
	}
	/**leave the queue*/
	public void leaveQueue() {
		inQueue=false;
	}
	
	/* getters*/
	public  String getName() {
		return name;
	}
	public  int getWeight() {
		return weight;
	}
	public  int getMinFloor() {
		return minFloor;
	}
	public  int getMaxFloor() {
		return this.maxFloor;
	}
	public Floor getDestination() {
		return destination;
	}
	public Floor getCurrentFloor() {
		return currentFloor;
	}
	public String toString() {
		return this.name;
	}
	public boolean getInLift() {
		return inLift;
	}
	public void setQueue(boolean q) {
		inQueue=q;
	}
	
	public boolean getWorkDone(People p) {
		return false ;
	}
	public boolean getQueue() {
		return inQueue;
	}
	
	/** part of the tick that is constant for all people*/
	public void constantTick() {
		if(inQueue) {
			averageTime++;
		}
		if ((!destination.equals(currentFloor)) && (!inLift) && (!inQueue)) {
			if (!(currentFloor.getButton().isPressed())) {
				System.out.println("button pressed");
				currentFloor.getButton().setPressed(true);
				
				currentFloor.addPersonQueue(this);
				inQueue=true;
				
			}else {
				currentFloor.addPersonQueue(this);
				inQueue=true;
				
			}
		}
			if( inQueue && !inLift && (build.getElevator().checkSpace()>=weight)&&
					build.getElevator().getFloor()==currentFloor.getFloorNum()) {
				//boolean filler=build.getElevator().getFloor()==currentFloor.getFloorNum();
			
				currentFloor.moveToLift();
				this.inLift=true;
				this.inQueue=false;
				build.addWaitingTime(averageTime);
				averageTime=0;
			
				
		}else {
			
		}
			
	
		
		if (destination.equals(currentFloor) && inLift) {
			
			
			destination.addPersonFloor(this);
			
			this.inLift=false;
			
			this.complained=false;
			waitingTime=0;
			this.inQueue=false;
			build.getElevator().removeStops(name);
					
			}
		if (inQueue && name=="C") {
			waitingTime++;
			
			complian(waitingTime);
		}
		if(!(destination.equals(currentFloor))){
		
		
		}
			}
		
	
	
	
	
	
	public void tick() {
		constantTick();
	}
	public boolean getWorkDone() {
		return false;
	}
	


}

