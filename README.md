# Temperature-Converter
This program allows the user to convert temperatures between Celsius, Fahrenheit, and Kelvin. The user can enter a 
temperature value in any one of the three units, and the program will automatically convert it to the other two units.

# How to use the program
1.	Run the program.
2.	Enter a temperature value in one of the three text boxes provided.
3.	The program will automatically convert the entered value to the other two units.
4.	If you enter an invalid input (e.g. non-numeric characters), the program will display an error message and clear all fields.
5.	If you enter values in more than one text box, the program will display an error message and clear all fields.

# Technical details
The program is written in C# and uses the .NET Framework. The GUI is created using Windows Forms. The code is divided into 
several methods, each responsible for converting temperatures between two units.

The onlyOneTextfieldFilled() method is used to verify that only one text box has data. The clearFields() method is used to clear the content of all text boxes.

To run the program, you will need to have Visual Studio or another compatible development environment installed on your computer. Once you have opened
the project, you can build and run the program using the "Start" button in the toolbar.

Note that this program only supports basic temperature conversions between Celsius, Fahrenheit, and Kelvin. 
More advanced temperature conversions (e.g. between Rankine or Réaumur) are not supported.

# Author
This program was created by Dereck Talavera.
