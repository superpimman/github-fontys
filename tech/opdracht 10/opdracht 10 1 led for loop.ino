int redPin = 8; 
int numBlinks = 3; 
int buttonPin = 7;
int buttonState = 0;

void setup()
{
  pinMode(redPin, OUTPUT);  
  digitalWrite(redPin, LOW); 
  pinMode(buttonPin, INPUT);
}
void loop()
{
  buttonState = digitalRead(buttonPin);
  if (buttonState == HIGH){
    
    for (int counter = 1; counter <= numBlinks; counter++) {
    digitalWrite(redPin, HIGH);
    delay(1000);
    digitalWrite(redPin, LOW);
    delay(1000);
  }
 }
}
