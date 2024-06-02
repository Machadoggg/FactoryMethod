

using FactoryMethod;



Vehicle vehicleObject = Creator.VehicleCreator(Creator.MOTORCYCLE);
//Vehicle vehicleObject = Creator.VehicleCreator(Creator.CAR);
//Vehicle vehicleObject = Creator.VehicleCreator(Creator.TRUCK);
Console.WriteLine($"{vehicleObject.MaxSpeed()} Km/Hr");


