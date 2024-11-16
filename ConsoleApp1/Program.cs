// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp1;


    //object for Car
    Car car = new Car();
    car.Make = "Lexus";
    car.Model = "RX-350";
    car.Year = 2022;

    //object for Motorcycle
    Motorcycle motorcycle = new Motorcycle();
    motorcycle.Make = "Suzuki";
    motorcycle.Model = "Dash";
    motorcycle.Year = 2023;

    //object for Truck
    Truck truck = new Truck();
    truck.Make = "Nissan";
    truck.Model = "Urban";
    truck.Year = 1998;

    //Calling object for Car
    Console.WriteLine($"{car.Make} \n");
    Console.WriteLine($"{car.Model} \n");
    Console.WriteLine($"{car.Year} \n");
    Console.WriteLine($"I have a {car.Year} {car.Make} {car.Model} Car \n");


    //Calling object for Motorcycle
    Console.WriteLine($"{motorcycle.Make} \n");
    Console.WriteLine($"{motorcycle.Model} \n");
    Console.WriteLine($"{motorcycle.Year} \n");
    Console.WriteLine($"I have a {motorcycle.Year} {motorcycle.Make} {motorcycle.Model} Motorcycle \n");
   

    //Calling object for Truck
    //Console.WriteLine($"{truck.Make} \n");
    //Console.WriteLine($"{truck.Model} \n");
    //Console.WriteLine($"{truck.Year} \n");
    //Console.WriteLine($"I have a {truck.Year} {truck.Make} {truck.Model} Truck \n");



    //Calling StartEngine,StopEngine and Drive method

    car.StartEngine();
    Console.WriteLine(car.Drive());
    car.StopEngine();
    Console.WriteLine("\n");



    motorcycle.StartEngine();
    Console.WriteLine(motorcycle.Drive());
    motorcycle.StopEngine();
    Console.WriteLine("\n");

    truck.StartEngine();
    Console.WriteLine(truck.Drive());
    truck.StopEngine();






