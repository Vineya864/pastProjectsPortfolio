package uk.aston.jpd.courseWork.elevator;
/**
 * 
 * 
 * 
 * 
 * @author aj-viney
 *
 */
import java.util.Random;
public class Employee extends People {
	Random randomTemp;

	public int ticks;
		public Employee(Building build,String name, int weight, int minFloor, int maxFloor) {
			super(build,name,  weight, minFloor,  maxFloor);
			
			randomTemp=new Random(getBuild().getSeed());
			ticks=0;
		
		}
		@Override
		public void tick() {
			ticks++;
			constantTick();
		
			double tempStore=getBuild().getEmployeeSimulator().newChance();
			
			tempStore=getBuild().getEmployeeSimulator().newChance();
			
			
			if(!(this.getInLift())   &&  getBuild().getEmployeeSimulator().EmployeeMoves(tempStore)) {				
				int randomStore=randomTemp.nextInt(getBuild().getFloors().size()-1);
				randomStore=randomTemp.nextInt(getBuild().getFloors().size()-1);
				randomStore=randomStore+this.getMinFloor();
			this.setDestination(getBuild().getFloors().get(randomStore));
			
			
			
		}
		
		}
}
