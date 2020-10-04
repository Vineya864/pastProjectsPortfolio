package uk.aston.jpd.courseWork.elevator;

import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.control.Slider;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
public class Result {
	@FXML
	TextArea outputText;
	private ArrayList<String>history; 
	private int ticks;
	public Result(MainSimulation run) {
		this.history=run.getRecord();
		//System.out.println(history.get(12));
		ticks=0;
		//outputText.setText("no text");
		//checkTicks(0);
	}
	
	@FXML
	public void initialize(MainSimulation output) {
		outputText.setText(history.get(0));
	}
	
	
		@FXML
		private void outputText(){
			outputText.clear();
			outputText.setText(history.get(ticks));
		}
		@FXML
		private void pressedHundred() {
			outputText.clear();
			checkTicks(100);
		}
		@FXML
		private void pressedOne() {
			outputText.clear();
			checkTicks(1);
		}
		@FXML
		private void pressedThousand() {
			outputText.clear();
			checkTicks(1000);
		}
		@FXML
		private void pressedTen() {
			outputText.clear();
			checkTicks(10);
		}
		@FXML
		private void resetPressed() {
			outputText.clear();
			ticks=0;
			checkTicks(0);
		}
		/**Check the ticks is allowed to be increased
		 * @param the value to increase */
		private void checkTicks(int increase) {
			
			if (ticks+increase>2880) {
				ticks=2880;
				outputText.appendText(history.get(2880)+"\nEND OF SIMULATION \n ");
				outputText.appendText("Tick number: "+ticks);
			
			}
			else {
				ticks=ticks+increase;
				outputText.appendText(history.get(ticks));
				outputText.appendText("\n Tick number: "+ticks);
			}
		}
		
		
		/**For use when testing*/
		public int getTicks() {
			return ticks;
		}
}
