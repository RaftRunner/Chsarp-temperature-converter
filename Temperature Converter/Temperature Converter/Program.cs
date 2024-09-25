// Write a program that chooses a temperature unit and then converts it to another chosen one
Console.WriteLine("Which unit of temperature do you want to start with? \n1.Celsius \n2.Farenheit \n3.Kelvin ");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("What is the temperature in Celsius? ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What do you want to convert it to? \n1.Farenheit \n2.Kelvin");
    int convertChoice = Convert.ToInt32(Console.ReadLine());

    if (convertChoice == 1)
    {
        Console.WriteLine("The converted temperature from Celsius to Farenheit is: " + celsiusToFarenheit(celsius));
    }
    else if (convertChoice == 2)
    {
		Console.WriteLine("The converted temperature from Celsius to Kelvin is: " + celsiusToKelvin(celsius));
	}
	else
    {
        Console.WriteLine("Not a valid choice");
    }
}
else if (choice == 2)
{
	Console.WriteLine("What is the temperature in Farenheit? ");
	double farenheit = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("What do you want to convert it to? \n1.Celsius \n2.Kelvin");
	int convertChoice = Convert.ToInt32(Console.ReadLine());

	if (convertChoice == 1)
	{
		Console.WriteLine("The converted temperature from Farenheit to Celsius is: " + farenheitToCelsius(farenheit));
	}
	else if (convertChoice == 2)
	{
		Console.WriteLine("The converted temperature from Farenheit to Kelvin is: " + farenheitToKelvin(farenheit));
	}
	else
	{
		Console.WriteLine("Not a valid choice");
	}
}
else if (choice == 3)
{
	Console.WriteLine("What is the temperature in Kelvin? ");
	double kelvin = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("What do you want to convert it to? \n1.Celsius \n2.Farenheit");
	int convertChoice = Convert.ToInt32(Console.ReadLine());

	if (convertChoice == 1)
	{
		Console.WriteLine("The converted temperature from Kelvin to Celsius is: " + kelvinToCelsius(kelvin));
	}
	else if (convertChoice == 2)
	{
		Console.WriteLine("The converted temperature from Kelvin to Farenheit is: " + kelvinToFarenheit(kelvin));
	}
	else
	{
		Console.WriteLine("Not a valid choice");
	}
}
else
{
    Console.WriteLine("Choose a valid option");
}

static double celsiusToFarenheit(double x)
{
    return (x * 9/5) + 32;
}

static double celsiusToKelvin(double x)
{
    return x + 273.15;
}

static double farenheitToCelsius(double x)
{
    return (x - 32) * 5 / 9;
}

static double farenheitToKelvin(double x)
{
    return (x - 32) * 5 / 9 + 273.15;
}

static double kelvinToCelsius(double x)
{
    return x - 273.15;
}

static double kelvinToFarenheit(double x)
{
	return (x - 273.15) * 9 / 5 + 32;
}