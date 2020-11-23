package uk.aston.jpd.courseWork.elevator;

import java.util.ArrayList;
import java.util.List;
/** Class for each floor will contain a list pf all the people on the floor and ticks the button*/
public class Floor {
	 public List<People> queue;
	    //arraylist for the people that are on the floor
	    private ArrayList<People> peopleToFloor;
	    public int floorNumber;
	    private Button button;
	    private Building build;
	    public Floor(int floorNumber,Button button) {
	    	//sets the floor number
	    	this.floorNumber = floorNumber;
	    	queue = new ArrayList<People>();
	    	peopleToFloor = new ArrayList<People>();
	    	this.button=button;
	    	
	    }
	    /**set the building once the floor has been made NEEDED FOR ANY FUTURE USE OF THIS CLASS 
	     * @param build the building that the floor is in
	     * */
	    public void setBuild(Building build) {
	    	this.build=build;
	    }
	    /**return the queue*/
	    public List<People> getQueue(){
	    	return queue;
	    }
	    
	    /**return the floor number */
	    public int getFloorNum() {
	    return floorNumber;
	    }
	      
	    /** add a person to the elevator queue*/
	    public void addPersonQueue(People p){
	    	//Q add p
	    	queue.add(p);
	    	//p.setQueue(true);
	    }
	   /** find a person and remove them */
	    public void removePersonFloor(People p){
	    	
	    	for(int i=0; i<peopleToFloor.size();i++) {
	    		
	    		if(peopleToFloor.get(i).equals(p)){
	    			peopleToFloor.remove(i);
	    			//System.out.println("removed");
	    			//p.setQueue(false);
	    			
	    		}
	    	}
	    	
	    }
	    /**add a person to the floor*/
	    public void addPersonFloor(People p){
	    	peopleToFloor.add(p);
	    	
	    
	    }
	    /** Return the button for the floor */
	    public Button getButton() {
	    	return button;
	    }
	    /**remove a person from the floor*/
	    public void removePersonQueue(People p){
	    	queue.remove(p);
	    	peopleToFloor.remove(p);
	    }
	    public String toString() {
	    	String people=floorNumber+" ";
	    
	    	people=people+" "+ peopleToFloor;
	    	
	    	people=people+":"+queue.size()+" in queue," +" "+peopleToFloor.size() +" On Floor";
	    	return(people);
	    }
	    /**return a person given there index-may later use their name
	     * @param I the persons index
	     * */
	    public People getPerson(int i) {
	    	return(peopleToFloor.get(i));
	    }
	    /**return the list of people on the floor */
	    public List<People> getAllPeople(){
	    	return (peopleToFloor);
	    }
	    /**move the first person in the queue into the lift */
	    public void moveToLift() {
	    	if(queue.size()>0&&peopleToFloor.size()>0) {
	    	if(build.getElevator().getFloor()==getFloorNum() &&  build.getHandle().addPerson(queue.get(0), build)) {
	    		
	    		queue.remove(0);
	    		peopleToFloor.remove(0);
	    	}
	    	}
	    	
	    }
	    
	    
	    /**
	     * ticks the floor
	     * @param build the building
	     * 
	     * */
	    public void tick(Building build ) {
	    	button.tick(build);
	    
	    }
}
