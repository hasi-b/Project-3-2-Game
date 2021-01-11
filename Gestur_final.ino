
int ledPin =(13); // Add the onboard LED on pin 13.
int trigPin = (5); // Add the Trig pin on pin 10.
int echoPin = (6); // Add the ECHO pin on pin 9.
int trigPin1 = (10); // Add the Trig pin on pin 10.
int echoPin1 = (11); // Add the ECHO pin on pin 9.
int duration, distance,distance1, duration1; // Add types 'duration' and 'distance'.
void setup()
{
  Serial.begin(9600);
pinMode (ledPin, OUTPUT); // The LED must be controlled by Arduino, it means it is an output type.
pinMode (trigPin, OUTPUT);// Same as above, the TRIG pin will send the ultrasonic wave.
pinMode (echoPin, INPUT); // The ECHO pin will recieve the rebounded wave, so it must be an input type.
pinMode (trigPin1, OUTPUT);// Same as above, the TRIG pin will send the ultrasonic wave.
pinMode (echoPin1, INPUT); // The ECHO pin will recieve the rebounded wave, so it must be an input type.
}
void loop()
{
digitalWrite (ledPin, LOW); // Here, LOW means off and HIGH means on.
digitalWrite (trigPin1, HIGH);
delay(50);
digitalWrite (trigPin1, LOW);
duration1=pulseIn(echoPin1,HIGH);
delay(50);

distance1=(duration1/2)/29.1;


digitalWrite (trigPin, HIGH);

delay(50);
digitalWrite (trigPin, LOW);
duration=pulseIn(echoPin,HIGH);
delay(50);
distance=(duration/2)/29.1;

if(distance1 <=30){ // If the sensor detects an obstacle less than 30 cm in distance, the LED will start to blink.
Serial.println("down");
digitalWrite (ledPin, HIGH);
delay(50); }
else if(distance1 >=30){// If no obstacle is there within 30 cm, the Led should turn off.
digitalWrite (ledPin, LOW);
delay(50);
}



if(distance <=30){ // If the sensor detects an obstacle less than 30 cm in distance, the LED will start to blink.
Serial.println("up");
digitalWrite (ledPin, HIGH);
delay(50);
}
else if(distance >=30){// If no obstacle is there within 30 cm, the Led should turn off.
digitalWrite (ledPin, LOW);
delay(50);
}



}
