package uk.aston.jpd.courseWork.elevator;

import java.util.Random;

public class Developers extends People {
	@SuppressWarnings("unused")
	private int ticks;
	Random randomTemp;
	@SuppressWarnings("unused")
	private String company;
	public Developers(Building build,String name, int weight, int minFloor, int maxFloor, String company) {
			super(build,name,  weight, minFloor,  maxFloor);
			ticks=0;
			randomTemp=new Random(getBuild().getSeed());
			int startingFloor= ((getBuild().getFloors().size()-1)/2) + randomTemp.nextInt((getBuild().getFloors().size()-1)/2);
			this.setDestination(build.getFloors().get(startingFloor));
			this.company=company;
	}	
	@Override
	public void tick() {
		ticks++;
		constantTick();
		//EmployeeSimulator temp = new EmployeeSimulator(getBuild().getSeed());
		double tempStore=getBuild().getEmployeeSimulator().newChance();
		
		tempStore=getBuild().getEmployeeSimulator().newChance();
		
		//if(ticks>25) {
		if(!(this.getInLift())   &&  getBuild().getEmployeeSimulator().EmployeeMoves(tempStore)) {
			
			int randomStore=randomTemp.nextInt((getBuild().getFloors().size()-1)/2);
			randomStore=randomTemp.nextInt((getBuild().getFloors().size()-1)/2);
			randomStore=this.getMinFloor()+randomStore;
		this.setDestination(getBuild().getFloors().get(randomStore));
		//this.setDestination(getBuild().getFloors().get(2));
		
		
		}
	//	}
	}
}
		
	
	
	
	
	
