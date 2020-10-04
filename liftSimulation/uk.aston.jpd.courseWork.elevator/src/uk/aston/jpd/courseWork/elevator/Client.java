package uk.aston.jpd.courseWork.elevator;

import java.util.Random;

public class Client extends People {
	private int ticks;
	Random randomTemp;
	private int workTicks;
	private int lengthOfStay;
	private boolean workDone; 
	public Client(Building build,String name, int weight, int minFloor, int maxFloor) {
		super(build,name,  weight, minFloor,  maxFloor);
		ticks=0;
		randomTemp=new Random(1);
			workTicks=0;
			lengthOfStay=0;
			workDone=false;
	}
	/**a client arrives at the building */
	public void clientCall() {
		this.getBuild().addToBuilding(this);
		this.getBuild().getFloors().get(0).addPersonFloor(this);
		this.setCurrentFloor(getBuild().getFloors().get(0));
		//this.setDestination(getBuild().getFloors().get(6));
		int randomStore=randomTemp.nextInt(getBuild().getFloors().size()-1);
		randomStore=randomTemp.nextInt(getBuild().getFloors().size()-1);
		randomStore=randomStore+this.getMinFloor();
		this.setDestination(getBuild().getFloors().get(randomStore));
		this.lengthOfStay=randomTemp.nextInt(120) +60;
		workTicks=0;
		workDone=false;
	}
	@Override
	public void tick() {
		if (this.getCurrentFloor().getFloorNum()==this.getDestination().getFloorNum()) {
			workTicks++;
		
		}

		if(workTicks>=lengthOfStay) {
						workDone=true;
						
				this.setDestination(getBuild().getFloors().get(0));
		}
			constantTick();	
			if(getCurrentFloor().getFloorNum()==0 && workDone) {
				//System.out.println("REMOVE FROM BUILDING");
				getBuild().getFloors().get(0).removePersonFloor(this);	
				getBuild().removeFromBuilding(this);
				//this.setCurrentFloor(null);
				workTicks=0;
				workDone=false;
			}
}
	@Override
	public boolean getWorkDone() {
		return workDone;
	}
}
