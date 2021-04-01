
var user;
var active;
var enemy;
var enemyTwo;
var enemyThree;
var Score;
var shot;
var shotTwo;
var flag
function startGame() {
 
   Score = new ScoreBoard("30px", "Consolas", "red", 280, 40, "text");
   document.getElementsByTagName('body')[0].style.overflow = 'hidden';
    myGameArea.start();
	
}

var myGameArea = {
    canvas : document.createElement("canvas"),
    start : function() {
        this.canvas.width = 680;
        this.canvas.height = 470;
        this.context = this.canvas.getContext("2d");
        document.body.insertBefore(this.canvas, document.body.childNodes[2]);
        this.frameNo = 0;
        this.interval = setInterval(updateGameArea, 20);
        },
    clear : function() {
        this.context.clearRect(0, 0, this.canvas.width, this.canvas.height);
    }
}



function updateGameArea() {
    
   if(!active){

	return;
   }
    myGameArea.clear();
    myGameArea.frameNo += 1;	
    
  
    user.newPos();
    user.update();
	
	shot.newPos();
	shot.update();
	shotTwo.newPos();
	shotTwo.update();
	enemy.newPos();//arrays not working so need less efficant form
	enemy.update();

	if (enemy.crashWith(shot)) {
            enemy.hit(user);
			 enemy=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemy.speedY=Math.floor(Math.random()*3)+ 1;
			shot.x = -10;
			shot.speedY=0;
			
    }
	if (enemy.crashWith(shotTwo)) {
            enemy.hit(user);
			 enemy=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemy.speedY=Math.floor(Math.random()*3)+ 1;
			shotTwo.x = -10;
			shotTwo.speedY=0;
			
    }
	if (enemy.crashWith(user)) {
            gameOver();
    }
	if(enemy.hitBottom()){
	enemy=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10)
		enemy.speedY=Math.floor(Math.random()*3)+ 1;;
	}
	
	enemyTwo.newPos();//arrays not working so need less efficant form
	enemyTwo.update();

	if (enemyTwo.crashWith(shot)) {
            enemyTwo.hit(user);
			 enemyTwo=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemyTwo.speedY=Math.floor(Math.random()*3)+ 1;
			shot.x = -10;
			shot.speedY=0;
		
    }
	if (enemyTwo.crashWith(shotTwo)) {
            enemyTwo.hit(user);
			 enemyTwo=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemyTwo.speedY=Math.floor(Math.random()*3)+ 1;
			shotTwo.x = -10;
			shot.speedY=0;
		
    }
	if (enemyTwo.crashWith(user)) {
            gameOver();
    }
	if(enemyTwo.hitBottom()){
	enemyTwo=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10)
		enemyTwo.speedY=Math.floor(Math.random()*3)+ 1;;
	}
	
	if (user.score>5){
		enemyThree.speedY=Math.floor(Math.random()*3)+ 1;
		enemyThree.newPos();//arrays not working so need less efficant form
	enemyThree.update();
	flag=true;
	}
	
		

	if (enemyThree.crashWith(shot)) {
            enemyThree.hit(user);
			 enemyThree=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemyThree.speedY=Math.floor(Math.random()*3)+ 1;
			shot.x = -10;
			shot.speedY=0;
		
    }
	if (enemyThree.crashWith(shotTwo)) {
            enemyThree.hit(user);
			 enemyThree=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10);
		enemyThree.speedY=Math.floor(Math.random()*3)+ 1;
			shotTwo.x = -10;
			shotTwo.speedY=0;
		
    }
	if (enemyThree.crashWith(user)) {
            gameOver();
    }
	if(enemyThree.hitBottom()){
	enemyThree=new Enemy(40, 60, "green", Math.floor(Math.random() * myGameArea.canvas.width), -10)
		enemyThree.speedY=Math.floor(Math.random()*3)+ 1;
	}
	
	
	  Score.text="SCORE: " + user.score;
	  Score.update();
}

function everyinterval(n) {
    if ((myGameArea.frameNo / n) % 1 == 0) {return true;}
    return false;
}


function reset(){
 
 spawn()
	myGameArea.frameNo=0;
	active=true;

}
function start(){
	document.getElementsByTagName('body')[0].style.overflow = 'hidden';
	spawn();
	active=true;
	
}

document.addEventListener('keydown', function(event) {
	
    if(event.keyCode == 37) {
        user.left(2);
    }
    else if(event.keyCode == 39) {
        user.right(2);
    }
	else if(event.keyCode == 38) {
        user.up(2);
    }
	else if(event.keyCode == 40) {
        user.down(2);
    }
	else if(event.keyCode == 32) {//space
	
        shoot(user.x+(user.width/2)-2.5);
		
		
	
    }
	
	
});

function spawn(){
         user = new User(40, 60, "blue", myGameArea.canvas.width/2, myGameArea.canvas.width-20);
		enemy=new Enemy(40, 60,  "green", myGameArea.canvas.width/2, 0)
		enemy.speedY=1;
		 enemyTwo=new Enemy(40, 60,  "green", myGameArea.canvas.width/2, -120)
		enemyTwo.speedY=1;
		enemyThree=new Enemy(40, 60,  "green", myGameArea.canvas.width/2, -10)
		enemyThree.speedY=1;
		active=true
		shot = new Bullet(10, 10, "red", width+10, user.y);
		shot.speedY=-5;
		shotTwo = new Bullet(10, 10, "red", width-10, user.y);
		shotTwo.speedY=-5;
		flag=false;
    }
   

function shoot(width){
	shot = new Bullet(10, 10, "red", width-10, user.y);
	shot.speedY=-5;
	shotTwo = new Bullet(10, 10, "red", width+5, user.y);
			shotTwo.speedY=-5;
	if (user.score<5){
		shotTwo.speedY=0;
		shotTwo.y=-10;
	}
}

function gameOver(){
	
	active=false;
	user.change(active)
}


