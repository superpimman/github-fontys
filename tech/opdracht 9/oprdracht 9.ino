int ledred = 8;
int ledgreen = 7;
int ledblue = 2;
int buttonPin = 12;
int buttonPin2 = 4;
int buttonState = 0;
int buttonState2 = 0;

void setup()
{
  pinMode(ledred, OUTPUT);
  pinMode(ledgreen, OUTPUT);
  pinMode(ledblue, OUTPUT);
  pinMode(buttonPin, INPUT);
  pinMode(buttonPin2, INPUT);
}

void loop()
{
 
  buttonState = digitalRead(buttonPin);

  if (buttonState == HIGH) {
    digitalWrite(ledred, HIGH);
    delay(1000);
    digitalWrite(ledred, LOW);
    
    digitalWrite(ledgreen, HIGH);
    delay(1000);
    digitalWrite(ledgreen, LOW);
    
    digitalWrite(ledblue, HIGH);
    delay(1000);
    digitalWrite(ledblue, LOW);
     } 
  else {
   
    digitalWrite(ledred, LOW);
    digitalWrite(ledgreen, LOW);
    digitalWrite(ledblue, LOW);
    
    
   buttonState2 = digitalRead(buttonPin2);
    
    if (buttonState2 == HIGH) {
       digitalWrite(ledblue, HIGH);
    delay(1000);
    digitalWrite(ledblue, LOW);
    
    digitalWrite(ledgreen, HIGH);
    delay(1000);
    digitalWrite(ledgreen, LOW);
    
    digitalWrite(ledred, HIGH);
    delay(1000);
    digitalWrite(ledred, LOW);
     
      
    }
    else {
    
    }
    
  }


}