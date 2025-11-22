using Lab3;

bool run = true;

do
{
    Console.WriteLine("CAR SHOP");
    Console.WriteLine("[1] Show all, [2] Search by year, ");
    Console.WriteLine("[3] Search by model, [4] Search by engine capacity, ");
    Console.WriteLine("[5] Add car, [0] Exit");

    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (input)
    {
        case '1':
            DisplayVehicleModel();
            break;
        case '2':
            SearchByYear();
            break;
        case '3':
            SearchByModel();
            break;
        case '4':
            SearchByEngineCapacity();
            break;
        case '5':
            AddNewVehicle();
            break;
        case '0':
            run = false;
            break;
        default:
            Console.WriteLine("Invalid menu option");
            break;
    }

} while (run);

Console.WriteLine("Goodbye...");
return;

// SHOW ALL

void DisplayVehicleModel()
{
    Console.WriteLine("Our vehicles:");

    foreach (var vehicle in Database.Vehicles)
    {
        Console.WriteLine(vehicle.Model);
    }
}



// SEARCH BY YEAR

void SearchByYear()
{
    Console.Write("Enter year: ");
    var success = Int32.TryParse(Console.ReadLine(), out int year);

    if (!success)
    {
        Console.WriteLine("Invalid year");
        return;
    }

    var vehicles = Database.Vehicles.Where(v => v.Year == year);

    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {
        foreach (var v in vehicles)
        {
            Console.WriteLine(v.Model);
        }
    }
}



// SEARCH BY MODEL

void SearchByModel()
{
    Console.Write("Enter model: ");
    string? model = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(model))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    var vehicles = Database.Vehicles
        .Where(v => v.Model.ToLower() == model.ToLower());

    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
        return;
    }

    foreach (var v in vehicles)
    {
        Console.WriteLine($"{v.Model}, {v.Year}, {v.EngineCapacity}L");
    }
}

// SEARCH BY ENGINE CAPACITY

void SearchByEngineCapacity()
{
    Console.Write("Enter engine capacity (e.g. 2,5L): ");

    var success = double.TryParse(Console.ReadLine(), out double capacity);

    if (!success)
    {
        Console.WriteLine("Invalid engine capacity");
        return;
    }

    var vehicles = Database.Vehicles
        .Where(v => Math.Abs(v.EngineCapacity - capacity) < 0.0001);

    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
        return;
    }

    foreach (var v in vehicles)
    {
        Console.WriteLine($"{v.Model} - {v.EngineCapacity} L ({v.Year})");
    }
}


// ADD NEW VEHICLE

void AddNewVehicle()
{
    Console.WriteLine("B for bike, C for car");
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (input.ToString().ToLower() != "b" && input.ToString().ToLower() != "c")
    {
        Console.WriteLine("Invalid vehicle type");
        return;
    }

    Console.Write("Enter engine capacity: ");
    var success = double.TryParse(Console.ReadLine(), out double engineCapacity);

    if (!success)
    {
        Console.WriteLine("Invalid engine capacity");
        return;
    }

    Console.Write("Enter model: ");
    string? model = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(model))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    Console.Write("Enter year: ");
    success = Int32.TryParse(Console.ReadLine(), out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        return;
    }

    Vehicle v;

    if (input == 'C' || input == 'c')
    {
        v = new Car(engineCapacity, model, year);
    }
    else
    {
        v = new Bike(engineCapacity, model, year);
    }

    Database.Vehicles.Add(v);

    Console.WriteLine("Added!");
}
