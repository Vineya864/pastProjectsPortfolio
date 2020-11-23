package uk.aston.jpd.courseWork.elevator;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Before;
import org.junit.Test;

import uk.aston.jpd.courseWork.elevator.MainSimulation;
public class MainSimulationTest {
	@Test
	public void getRanTest() {
		MainSimulation test=new MainSimulation();
		assertFalse(test.getRan());
		int[] nums={1,2,3,4};
		String [] strings={"0.5","0.02"};
		test.main(nums,strings);
		assertTrue(test.getRan());
	}
}
