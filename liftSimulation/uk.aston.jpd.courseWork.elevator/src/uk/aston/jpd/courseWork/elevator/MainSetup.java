package uk.aston.jpd.courseWork.elevator;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import uk.aston.jpd.courseWork.elevator.Setup;


public class MainSetup extends Application {
	
	public static void main(String[] args) {
		Application.launch(args);
	}
	

	@Override
	public void start(Stage primaryStage) {
		try {
	    
			//open first window
			final FXMLLoader loader = new FXMLLoader();
			loader.setLocation(getClass().getResource("CreateSimulation.fxml"));
			loader.setController(new Setup());
			final Parent root = loader.load();

			final Scene scene = new Scene(root, 400, 450);
			primaryStage.setTitle("Setup");
			primaryStage.setScene(scene);
			primaryStage.show();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
}
	