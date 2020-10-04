package uk.aston.jpd.courseWork.elevator;

public class EmployeeSimulator extends EventSimulator {
/**
 * Author Andrew Viney
 */
double p;
int decimal;
double q;

		public EmployeeSimulator(int seed,double pValue,double qValue) {
			super(seed);
			this.p=pValue;
			this.q=qValue;
			this.p=p*1000;
		
			this.q=q*1000;
			
			if (q<0.1) {
				q=-1;
			}
			else {
				this.q++;
			}
			if (p<0.1) {
				p=-1;
			}
			else {
				this.p++;
			}
			}
		/** given a number decides if a new client arrives*/
		public boolean clientArrives(double num) {
			
			if(num<q) {
				return true;
				
			}else {
				return false;
			}
		}
		

		/** given a number decides if a Employee moves*/
		public boolean EmployeeMoves(double num) {
			
			if(num<p) {
				return true;
				
			}else {
				return false;
			}
		}
		

		/** given a number decides if a new maintance arrives*/
		public boolean maintanceArrives(double num) {
			if(num<6) {
				return true;
			}
			else {return false;}
		}
		
		
		 
		 
		 





		}

