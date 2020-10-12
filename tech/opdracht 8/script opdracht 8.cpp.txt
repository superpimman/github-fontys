const int buttonPin = 2;     
const int ledPin =  12; 
const int ledPin2 = 4;
const int buttonPin2 = 8;


int buttonState = 0;
int buttonState2 = 0;

void setup() {
 
  pinMode(ledPin, OUTPUT);
  
  pinMode(buttonPin, INPUT);
  
  pinMode (ledPin2, OUTPUT);
  
  pinMode (buttonPin2, INPUT);
}

void loop() {
 
 buttonState = digitalRead(buttonPin);

  
  if (buttonState == HIGH) {
    
    digitalWrite(ledPin, HIGH);
    delay(1000);
     } else {
   
    digitalWrite(ledPin, LOW);
    delay(100);
    
    
  }
 buttonState2 = digitalRead(buttonPin2);
  
  if (buttonState2 == HIGH)
  {
    digitalWrite(ledPin2, HIGH);
    delay(1000);
  } 
  else{
    digitalWrite(ledPin2, LOW);
    delay(100);
    
     
   }
 }
