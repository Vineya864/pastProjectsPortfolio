class Score {
  private int score;
  
  public Score(){
   score=0 ; 
        }
  
  public void display(){
   textSize(32);
text("Score: "+score, 5, 30);  
    
  }
  
  
  public void addOne(){
   score=score+1; 
    
    
  }
  
  public void gameOver(){
       textSize(32);
       fill(255,0,0);
text("Score: "+score, 5, 30);  
  }
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
}
