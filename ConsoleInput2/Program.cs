// See https://aka.ms/new-console-template for more information

//************************Questions*****************************
// 1.Write a program that will ask for username and age, and then display a greeting with the user’s name, and age.
//
// 2. Create a program that will convert a temperature from degrees Celsius to degrees Fahrenheit. The conversion
// for Celsius to Fahrenheit is: (oC X 9/5) + 32 = oF
//**************************************************************

// Input user name and age
String userName;
int age;
Console.Write("Please enter your name: ");
userName = Console.ReadLine() ?? "";

Console.Write("Please enter your age: ");
age = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Your name is {userName} and age is {age}");
Console.WriteLine("");

// Input a temperature in degree Celsius, then convert it in degree Fahrenheit
float degreeCelsius;
float degreeFahrenheit;
Console.Write("Please enter a temperature in degree Celsius: ");
degreeCelsius = float.Parse(Console.ReadLine() ?? "0");
degreeFahrenheit = (degreeCelsius * 9 / 5) + 32;
Console.WriteLine("The temperature in dgree Fahrenheit is: {0}", degreeFahrenheit);
