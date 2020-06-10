class Traffic {
  private float x;
  private float y;
  private color clr;
  private float theSize;
  private char xDirection;
  private char yDirection;
  private float speed;

  public Traffic(float gX, float gY, float size, color c) {
    x=gX;
    y=gY;
    theSize=size;
    clr=c;
    speed=random(0.5,3);
  }

  public void display() {
   drawing();
  }
  private void drawing(){
   float wheelOffset = theSize / 4;
    rectMode(CENTER);
    stroke(0);
    fill(clr);
    rect(x, y, theSize, theSize/2);
    fill(0);
    rect(x - wheelOffset, y - wheelOffset, 
      wheelOffset, wheelOffset/2);
    rect(x + wheelOffset, y - wheelOffset, 
      wheelOffset, wheelOffset/2);
    rect(x - wheelOffset, y + wheelOffset, 
      wheelOffset, wheelOffset/2);
    rect(x + wheelOffset, y + wheelOffset, 
      wheelOffset, wheelOffset/2);
  
}
  public float getx() {
    return x;
  }
  public float gety() {
    return y;
  }

  public void move(char direction,Score score) {
    if (checkCrash(car)) {
      rectMode( CENTER);
      fill(255, 0, 0);
      noStroke();
      
      rect(x, y, 10, 50);
      rect(x,y, -50, -10);
      score.gameOver();

      noLoop() ;
    }
    x=x-speed;
    if (direction=='d') {
      x=x-1;
    } else if (direction=='a') {
      x=x;
    }
  }
  public float distance(float x1, float x2, float y1, float y2) {  //calculate distance pythag
    float value=sqrt(pow(x2-x1, 2)+pow(y2-y1, 2));
    return value ;
  }
  public boolean checkCrash(Car car) {
    float crash= distance(x, car.getX(), y, car.getY());
//    float crashTake= distance(x-theSize/3, car.getX(), y, car.getY()-theSize/3);

    if (crash<=0-theSize/2) {
      return true;
    } else if (crash<=0+theSize/2) {
     return true;
    } else {
      return false;
    }
  }
  
 public void compleated(Score board){
   if (round(x)<=-20){
  
    board.addOne(); 
    nextLevel(); 
   }
   
 }
 private void nextLevel(){
 y=random(10,height-10);
 x=random(width,width*1.5);
 speed=random(0.5,3);
 
 }
}
