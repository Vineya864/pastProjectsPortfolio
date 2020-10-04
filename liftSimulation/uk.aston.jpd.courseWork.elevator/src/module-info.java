module uk.aston.jpd.courseWork.elevator {
	requires junit;
	requires javafx.controls;
	requires javafx.fxml;
	requires transitive javafx.graphics;
	
	exports uk.aston.jpd.courseWork.elevator;
	
	opens uk.aston.jpd.courseWork.elevator to javafx.fxml;
}