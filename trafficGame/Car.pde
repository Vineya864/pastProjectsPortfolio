class Car {
  private float x;
  private float y;
  private color clr;
  private float theSize;
  private char xDirection;
  private char yDirection;

  public Car(float gX, float gY, float size, color c) {
    x=gX;
    y=gY;
    theSize=size;
    clr=c;
    xDirection='d';
  }


  public void display() {
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
  public void move() {
   
      if (xDirection=='d') {
        x=x+0.5;
      } else if (xDirection=='a') {
        x=x-1.2;
      } else {
        x=x-1;
      }

      if (yDirection=='w') {
        y--;
      } else if (yDirection=='s') {
        y++;
      }
      checkEdge();
    }
  
  void keyPressed() {
    if (key=='d') {
      xDirection='d';
    } else if (key=='a') {
      xDirection='a';
    }

    if (key=='s') {
      yDirection='s';
    } else if (key=='w') {
      yDirection='w';
    } else {
      yDirection='v';
    }
  }


  private void checkEdge() {
    if (x<=0) {
     x=0;
    } else if (x>=width) {
      x=width;
    }
    if (y>=height) {
      y=height;
    } else if (y<=0) {
      y=0;
    }
  }
  
  public char getDirection(){
    return xDirection;
  }
  public float getY(){
    return y;
}


  public float getX(){
    return x;
  }

}
