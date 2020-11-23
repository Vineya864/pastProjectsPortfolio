package uk.aston.jpd.courseWork.elevator;
import java.util.Random; 
/**
 * 
 * @author aj-vi
 *
 */
public  class EventSimulator {
	Random chance;
	public EventSimulator(int seed) {
		chance=new Random(seed);
		
		
	}
	public double newChance() {
		double result = chance.nextInt(1000)+chance.nextDouble();
		
		 return result;
	}
}
