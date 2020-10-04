	package uk.aston.jpd.courseWork.elevator;
	import static org.junit.Assert.assertEquals;
	import static org.junit.Assert.assertFalse;
	import static org.junit.Assert.assertTrue;

	import java.io.IOException;
	import java.util.ArrayList;

	import org.junit.Before;
	import org.junit.Test;

	import uk.aston.jpd.courseWork.elevator.EmployeeSimulator;
public class EmployeeSimulatorTest {
	@Test
	public void maintanceTest() {
		EmployeeSimulator empSim= new EmployeeSimulator(10,.001,0.02);
		assertFalse(empSim.maintanceArrives(7));
		assertTrue(empSim.maintanceArrives(2));
		assertFalse(empSim.maintanceArrives(6));
	}
	@Test
	public void clientArrivesTest() {
		EmployeeSimulator empSim= new EmployeeSimulator(10,0.01,0.02);
		assertTrue(empSim.clientArrives(1));
		assertFalse(empSim.clientArrives(100));
	}

	@Test
	public void employeeMovesTest() {
		EmployeeSimulator empSim= new EmployeeSimulator(10,.001,0.02);
		assertTrue(empSim.EmployeeMoves(1));
		assertFalse(empSim.EmployeeMoves(10));
	}
	
}
