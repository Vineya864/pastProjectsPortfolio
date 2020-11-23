package uk.aston.jpd.courseWork.elevator;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
//import java.util.List;
import java.util.Scanner;
/**Create the class to hold the simulation*/
public class MainSimulation {
	private boolean ran; 
	/**Return whether the simulation has finished*/
	public boolean getRan() {
		return ran;
	}
	private ArrayList<String> record;
	/**set up and run the simulation
	 * @param args an array of integers for numbers
	 * @param  probs an array of Strings for the probabilities*/
	public  void main(int[] args,String[] probs) {//get users numbers
		ran=false;
	int calls=0;
	int maintanceNumber=0;
	 int clientNumber=0;
	 int floorNumber=0;
/*
	Scanner input = new Scanner(System.in);
		System.out.println("Enter how many Employees: ");
		int eNumber = input.nextInt();
		System.out.println("Enter how many Developers: ");
		int dNumber = input.nextInt();
		System.out.println("Enter random number seed: ");
		int seed = input.nextInt();
		input.close();
	*/
	 
	 
	 //get values from setup
	 	int eNumber=(args[0]);
	 	int dNumber=(args[1]);
	 	int seed=(args[2]);
	 	floorNumber=(args[3]);
	 	double qValue= Double.parseDouble(probs[0]);
	 	
	 	double pValue= Double.parseDouble(probs[1]);
	 	
		ElevatorHandler handle = new ElevatorHandler();
		Elevator lift = new Elevator(4);
		ArrayList<Floor> floorList;
		floorList=new ArrayList();
		int nameInt=0;
		
		ArrayList<People>peopleOnFloor;
		
	
		//create floors
		for (int i=0; i<floorNumber;i++) {
			Button button= new Button(i);
			Floor temp=new Floor(i,button);	
			
			floorList.add(temp);
		}
		List<People>allPeople=new ArrayList<People>();
		Building office = new Building(handle,lift,floorList,allPeople,seed,pValue,qValue);
		lift.setBuild(office);
		//create employees and add them to the floor
		for(int i=0;i<eNumber;i++) {
			People employee =new Employee(office,"E"+i,1,0,6);
			floorList.get(0).addPersonFloor(employee);
		}
		//create developers and add them to the floor
		for(int i=0;i<dNumber;i++) {
			People developer =new Developers(office,"D"+i,1,(floorNumber-1)/2,6,"company");
			floorList.get(0).addPersonFloor(developer);
		}
		//set the floors to the building
		for(Floor F: floorList) {
			F.setBuild(office);
		}
		//add the employees to the building
		for(int i=0;i<eNumber;i++) {
			
			office.addToBuilding(floorList.get(0).getPerson(i));
		}
		
		//Maintance crew********* five created 
		People maintance =new Maintance(office,"M0",4,0,7);
		People maintance1 =new Maintance(office,"M1",4,0,7);
		People maintance2 =new Maintance(office,"M2",4,0,7);
		People maintance3 =new Maintance(office,"M3",4,0,7);
		People maintance4 =new Maintance(office,"M4",4,0,7);
		List<Maintance> maintanceList = new ArrayList<Maintance>();
		maintanceList.add((Maintance) maintance);
		maintanceList.add((Maintance) maintance1);
		maintanceList.add((Maintance) maintance2);
		maintanceList.add((Maintance) maintance3);
		maintanceList.add((Maintance) maintance4);
		//************************* 
		//Client*************
		People client=new Client(office,"C",1,0,7);
		List<Client> clientList = new ArrayList<Client>();
		clientList.add((Client) client);
		People client1=new Client(office,"C",1,0,7);
		clientList.add((Client) client1);
		People client2=new Client(office,"C",1,0,7);
		clientList.add((Client) client2);
		People client3=new Client(office,"C",1,0,7);
		clientList.add((Client) client3);
		People client4=new Client(office,"C",1,0,7);
		clientList.add((Client) client4);
		//**************************
		//add developers to the building
		for(int i=0;i<dNumber;i++) {
			
			office.addToBuilding(floorList.get(0).getPerson((eNumber)+i));
		}
		office.addToBuilding(maintance);
	
		//show the building
		office.showBuilding();
		Random temp;
		//set the starting destination for the different people
		for(int i=0;i<office.getFloors().get(0).getAllPeople().size();i++) {
			
			temp=new Random(1);
			int randomStore=temp.nextInt(office.getFloors().size()-1);
			office.allPeople.get(i).setDestination(office.getFloors().get(randomStore));
			randomStore=temp.nextInt(office.getFloors().size()-1);
			if(i>=eNumber) {
				randomStore=temp.nextInt(((office.getFloors().size()-1)/2));
				randomStore=randomStore+((office.getFloors().size()-1)/2);
				office.allPeople.get(i).setDestination(office.getFloors().get(randomStore));
				System.out.println(randomStore);
				randomStore=temp.nextInt(3);
			}
		}
		
		
		//run the simulation
		//each tick is 10 seconds
		record=new ArrayList<>();
		for(int i=0; i<2881;i++) { //2880
			office.tick();
			if(i>18) {
				
						if(office.getEmployeeSimulator().maintanceArrives(office.getEmployeeSimulator().newChance())&& maintanceNumber< maintanceList.size()) {		
					maintanceList.get(maintanceNumber).maintanceCall();
					maintanceList.get(maintanceNumber).setDestination(office.getFloors().get(office.getFloors().size()-1));
					maintanceNumber++;
					if (maintanceNumber+1==maintanceList.size()) {
						maintanceNumber=0;
					}
				}
				
				if(office.getEmployeeSimulator().clientArrives(office.getEmployeeSimulator().newChance())&&clientNumber<clientList.size()) {		
					clientList.get(clientNumber).clientCall();
					maintance.setDestination(office.getFloors().get(office.getFloors().size()-1));
					clientNumber++;
					if (clientNumber+1==clientList.size()) {
						clientNumber=0;
					}
				
				}
				
			}
			//add this tick to the record
			record.add(office.showBuilding()+"\n"+ office.getComplaints() +"\n Average Waiting Time: "+ office.getAverageWaitingTime()+" Seconds");
			office.showBuilding();//show on the command line
			System.out.println(i);
			
			//System.out.println(calls);
			
		}
		System.out.println(office.getComplaints());
		//System.out.println(record.get(2));
		ran=true;
	}
/**get access the record of the ticks*/
	public ArrayList<String> getRecord() {
		return record;
	}
	}
/*
 * currently we can add people to the lift but they donot get back out of it whe  they reach their floor
 * 
 * 
 */









/*
 *The Lift Works to the 69% requirements as well as lodging complaints
 * from the clients 
 *on some seeds the program does break
 *
 *
 */