Car car;
Traffic[] traffic;

Score scoreBoard;
void setup(){
  traffic=new Traffic [10];
 size(900,300);
 car=new Car(50,100,60, color(0,0,255));
 for (int i=0; i<traffic.length;i++){
 traffic[i]=new Traffic(random(width,width*i),random(10,height-10),60, color(random(0,255),random(255,0), 0));
 }
 scoreBoard= new Score();
}
void draw(){
 background(100);
 road();
scoreBoard.display();
 car.display(); 
 for (int i=0; i<traffic.length;i++){
 trafficDisplay(traffic[i]);
 }
 
 car.keyPressed();
 car.move();
 for (int i=0; i<traffic.length;i++){
 trafficControl(traffic[i]);
 }
}
void road(){
  fill(255);
  for (int h=0; h<height/50; h++){
  for(int i=0; i<width/50; i++){
   rect(0+(i*60),(height-30)-(h*70) ,40,10);
  }
  }

}
void trafficDisplay(Traffic traffic){
  traffic.display();
  
}
void trafficControl(Traffic traffic){
  traffic.move(car.getDirection(),scoreBoard);
  traffic.compleated(scoreBoard);
    
    
  }
