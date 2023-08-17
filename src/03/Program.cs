int [] myArray = new int [7];
int myArrayValue;
int myFirstVariable = 10;
int mySecondVariable = 2;
for (int index = 0; index < 7; index++)
{
  myArrayValue = myArray[index] = (index * 3);
  //Ausgabe erfolgt wenn der Wert >= 5 ist
  if (myArrayValue >= 5)
  {
    Console.WriteLine($"Array Wert in Index :  {index} ist : {myArrayValue}");
  }
}

for (int i = 0; i < 10; i++)
{
  
  myFirstVariable = myFirstVariable + 1;
  mySecondVariable = mySecondVariable + 2;
  if (mySecondVariable > myFirstVariable)
  {
    Console.WriteLine($"Array Wert in Index :  {i} ist : {myFirstVariable} {mySecondVariable}");
  }
  
}