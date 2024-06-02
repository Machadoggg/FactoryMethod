

using FactoryMethod;



Vehicle vehicleObject = Creator.VehicleCreator(Creator.CAR);
Console.WriteLine(vehicleObject.MaxSpeed());


