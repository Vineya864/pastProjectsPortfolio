package uk.aston.jpd.courseWork.elevator;

import java.util.Random;

public class Maintance extends People {
	Random randomTemp;
	private int ticks;
	private int workTicks;
	private int lengthOfStay; 
	private boolean workDone;
	
	//EmployeeSimulator temp;
	public Maintance(Building build,String name, int weight, int minFloor, int maxFloor) {
		super(build,name,  weight, 0,  6);
		//temp = new EmployeeSimulator(getBuild().getSeed(),0.001);
		randomTemp=new Random(getBuild().getSeed());
		ticks=0;
		workDone=false;
	
	}
	@Override
	public boolean getWorkDone() {
		return workDone;
	}
	
	public void maintanceCall() {
		
		this.getBuild().addToBuilding(this);
		this.getBuild().getFloors().get(0).addPersonFloor(this);
		this.setCurrentFloor(getBuild().getFloors().get(0));
		this.setDestination(getBuild().getFloors().get(getBuild().getFloors().size()-1));
		scrableChance();
		this.lengthOfStay=randomTemp.nextInt(120) +120;
		
		workTicks=0;
	}
	public double scrableChance() {
		double tempStore=0;
		for(int i=0 ; i<5; i++) {
			tempStore=getBuild().getEmployeeSimulator().newChance();
			
			tempStore=getBuild().getEmployeeSimulator().newChance();
		}
		return tempStore;
	}
	
	@Override
	public void tick() {
		if (this.getCurrentFloor().getFloorNum()==getBuild().getFloors().size()-1) {
			workTicks++;
		
		}
		
		
		
		//System.out.println(workTicks>=lengthOfStay);
		
		
		
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
				getBuild().SetMaintanceInHouse(false);
			}
}
		
	public int getWorkTicks() {
		return workTicks;
	}
	
}

	



