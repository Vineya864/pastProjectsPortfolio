package uk.aston.jpd.courseWork.elevator;

import java.util.ArrayList;
import java.util.List;
/**
 * 
 * 
 *
 *
 */
public class Building {
 private List<Floor> floors;
 private Elevator lift;
 private ElevatorHandler handle;
 public List<People> allPeople;
 public EmployeeSimulator empSim;
 private boolean maintanceInHouse; 
 public int seed;
 public int complaintNumber;
 private List<Integer> waitingTime;
 public Building(ElevatorHandler handle,Elevator lift, List<Floor> floors, List<People>allPeople,int seed,double pValue,double qValue ) {
	 this.floors= floors;
	 this.lift=lift;
	 this.handle=handle;
	 this.allPeople=allPeople;
	 empSim=new EmployeeSimulator(seed,pValue,qValue);
	 this.seed=seed;
	maintanceInHouse=false;
	complaintNumber=0;
	waitingTime=new ArrayList<Integer>();
	 
 }
 
 /**and the time to the waiting times
  * @param Time in ticks
  * */
 public void addWaitingTime(int time) {
	 waitingTime.add(time);
 }
 /**get the time in seconds */
 public double getAverageWaitingTime() {
	 int total=0;
	 double time=0;
	 for(int i:waitingTime) {
		 total=total+i;
	 }
	 if(total>0) {
	time=(total/waitingTime.size());
	 time=time*10;}
	 return time;
 }
 
 public void addComplaintNumber() {
	 complaintNumber++;
 }
 public List<People> getAllPeople() {
	 return allPeople;
 }
 public void SetMaintanceInHouse(boolean maintanceInHouse) {
	this.maintanceInHouse= maintanceInHouse;
 }
 public boolean getMaintanceInHouse() {
	 return maintanceInHouse;
 }
 public int getSeed() {
	 return seed;
 }
 public EmployeeSimulator getEmployeeSimulator() {
	return empSim; 
 }
 
 public Elevator getElevator() {
	 return lift;
 }
 public void addToBuilding(People p) {
	 allPeople.add(p);
 }
 /**
  * @param p a person to be removed
  * */
 public void removeFromBuilding(People p) {
	 System.out.println("REMOVE FROM BUILDING");
	 for(int i=0; i<allPeople.size();i++ ) {
		 if(allPeople.get(i).equals(p)) {
			 if (p.getWorkDone()) {
			 allPeople.remove(i);
			 }
		 }
	 }
 }
 public ElevatorHandler getHandle() {
	 return handle;
 }
 public void tick() {
	 
	 for(int i=0; i<floors.size();i++) {
		 floors.get(i).tick(this);		
	 }
	 lift.tick();
	 for (int i=0; i<allPeople.size();i++) {
		 allPeople.get(i).tick();
	 }
	 
		 
 }
 public ArrayList<Floor> getFloors(){
	 return (ArrayList<Floor>) floors;
 }
 /** print out the layout of the building */
 public String showBuilding() {
	 String output="";
	 for (int i=floors.size()-1; i>-1;i--) {
	 System.out.println(floors.get(i));
	 output=output+"\n"+floors.get(i);
 }
	 System.out.println(lift);
	 output=output+"\n"+lift;
	 return output;
}
 /**
  * return the number of complaints as a sentence like a to string function */
 public String getComplaints() {
	 return("There were : "+complaintNumber+" complaints");
 }
}
