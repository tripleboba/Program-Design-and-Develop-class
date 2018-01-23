### Code a Console App to Calculate Letter Grade

Result should look like this but work for all valid grades entered.
![capture](https://user-images.githubusercontent.com/17074372/35258541-3ac7e9b6-ffce-11e7-9ebf-431d23fb48e1.PNG)

Specification:

1. Prompt the user for a numeric grade

     hint: Use the following to get user input.  
     ````
     Console.WriteLine("Enter a numeric grade to convert: ");
     int numberGrade =  int.Parse(Console.ReadLine());
     ````

2. Use  if-else statement to set the letter grade

     Grade Conversions to be used:
     
     Numeric Grade|Letter Grade
     ---------------|---------------
     Greater than 88|A
     Between 88 and 80|B
     Between 79 and 68|C
     Between 67 and 60|D
     Lower than 60|F


3. Print out the resulting letter grade to the user
