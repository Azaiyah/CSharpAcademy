﻿// sudo apt-get update
// sudo apt-get install -y dotnet-sdk-8.0
// git add . | git commit -m "text" | git push origin main 


// Start of the project - Math Game 
// Math game - 4 different modes (add, substract, mulitply, divide), 5 rounds


using System.Security.Cryptography.X509Certificates;

void Menu()
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Substract");
    Console.WriteLine("3. Mulitply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("-----------------------------------------");
}

int Add(int x, int y)
{
    return x + y; 
}

int Substract(int x, int y)
{
    return x - y;
}

int Multiply(int x, int y)
{
    return x * y; 
}

int Divide(int x, int y)
{
    return x / y; 
}


Menu();

Console.Write("\nThis is your choice: ");
string choice = Console.ReadLine();


switch (choice)
{
    case "1":
        Console.WriteLine();
        break; 
    
    case "2":
        Console.WriteLine();
        break; 
    
    case "3":
        Console.WriteLine("Add");
        break; 
    
    case "4":
        Console.WriteLine("Add");
        break; 
    
    default: 
        Console.WriteLine("Fail");
        break; 
    
}