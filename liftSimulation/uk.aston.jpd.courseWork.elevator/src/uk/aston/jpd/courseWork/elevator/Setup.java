package uk.aston.jpd.courseWork.elevator;

import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Label;
import javafx.scene.control.Slider;
import javafx.scene.control.TextField;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
public class Setup {
	//Declare variables
	boolean created;
	@FXML
	private Label pLabel;
	@FXML
	private Label qLabel;
	@FXML
	private TextField seedText ;
	
	@FXML
	private Label floorLabel;
	
	@FXML
	private Label employeeLabel;
	
	@FXML
	private Label  devLabel;
	
	@FXML 
	private Slider employeeSlide;
	@FXML
	private Slider pSlide;
	@FXML
	private Slider qSlide;
	@FXML 
	private Slider devSlide;
	
	@FXML
	private Slider floorSlide;
	
	
	@FXML 
	public void createPressed() {
		try {
		int[] Values= {getValues().get(0),getValues().get(1),getValues().get(2),getValues().get(3)};
		close();
		MainSimulation run =new MainSimulation();
		
	//launch the main simulation
		run.main(Values,getProbs());
		if (run.getRan()) {
			//if the simulation is finished
			final FXMLLoader loader = new FXMLLoader();
			loader.setLocation(getClass().getResource("ResultsOnScreen.fxml"));
			Result results=new Result(run);
			loader.setController(results);
			try {
				final Parent parent = (Parent) loader.load();

				final Stage removeStage = new Stage();
				removeStage.initModality(Modality.APPLICATION_MODAL);
				removeStage.setScene(new Scene(parent, 500, 350));
				removeStage.showAndWait();
				//show the outcome
			} catch (IOException ex) {
				ex.printStackTrace();
			}
			
		}
	} catch(NumberFormatException nu){
		//If the seed is not given show an alert and reset the seed box
		seedText.setText("");
		Alert alert= new Alert(AlertType.WARNING,"Please Enter A Number For The Seed");
		alert.show();
	}
	}
	
	
	@FXML 
	public void cancelPressed() {
		employeeLabel.getScene().getWindow().hide();
	}

	
	@FXML
	public void initialize() {
		int eValuePlaying=(int) (employeeSlide.getValue());
		employeeLabel.setText("Number of Employees:" + eValuePlaying );
		int dValueNumber=(int) (devSlide.getValue());
		devLabel.setText("Number of Developers:" + dValueNumber );
		created=false;
	}
	
	
	public Setup() {
		
	}

	@FXML void onQChanged() {
		DecimalFormat df = new DecimalFormat("#.####");
		Double qValue=(Double) (qSlide.getValue());
		qLabel.setText("Q Value:" + df.format(qValue) );
	}
	
	@FXML
	public void onPChanged() {
		DecimalFormat df = new DecimalFormat("#.####");
		Double pValue=(Double) (pSlide.getValue());
		
		pLabel.setText("p Value:" + df.format(pValue) );
	}
	
	@FXML
	public void onEmployeeChanged() {
		int eValue=(int) (employeeSlide.getValue());
		employeeLabel.setText("Number of Employees:" + eValue);
	}
	
	@FXML
	public void onDevChanged() {		
		int dValuePlaying=(int) (devSlide.getValue());
		devLabel.setText("Number of Developers:" + dValuePlaying );
	}
	@FXML
	public void onFloorChanged() {
		
		int fValue=(int) (floorSlide.getValue());
		floorLabel.setText("Number of Floors:" + fValue );
	   
	}
	public boolean getCreated() {
		
		return created;
		
	}
	public ArrayList<Integer> getValues() {
		ArrayList<Integer>values=new ArrayList<>();
		values.add((int) employeeSlide.getValue());
		values.add((int) devSlide.getValue());
		String text=seedText.getText();
		int seed=Integer.parseInt(text);
		
		values.add(seed);
		values.add((int)floorSlide.getValue());
		return values;
		
	}
	public String[] getProbs(){
		
		DecimalFormat df = new DecimalFormat("#.####");
		

		String[] probs= {df.format(pSlide.getValue()), df.format(qSlide.getValue())};
		return probs;
	}
	public void close() {
		employeeSlide.getScene().getWindow().hide();
	}
}
