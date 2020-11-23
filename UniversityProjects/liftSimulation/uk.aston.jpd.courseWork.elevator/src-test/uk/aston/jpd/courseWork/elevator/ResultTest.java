package uk.aston.jpd.courseWork.elevator;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.io.IOException;
import java.util.ArrayList;

import org.junit.Before;
import org.junit.Test;

import uk.aston.jpd.courseWork.elevator.Result;
public class ResultTest {
@Test
public void increaseTicks() {
	MainSimulation test=new MainSimulation();

	int[] nums={1,2,3,4};
	String [] strings={"0.5","0.02"};
	
	Result results=new Result(test);
	assertEquals(results.getTicks(),0);
	
	
	
}
}
