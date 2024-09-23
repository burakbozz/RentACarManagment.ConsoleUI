

using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Model.Dtos;
using RentACarManagement.ConsoleUI.Repository;
using RentACarManagement.ConsoleUI.Service;

CarService carService = new CarService();

Car car = new Car(6,1,3,4,"kiralık",12300,2011,"34 UZ 34","RENAULT","MEGANE",500000);
Color color = new Color(6, "gray");
Fuel fuel = new Fuel(6, "hidrojen");
Transmission transmission= new Transmission(5,"deneme");


//carService.Add(car);
//carService.GetById(1);
//carService.Remove(1);
//carService.Update(1, car);
//carService.GetAll();
//carService.GetDetails();
//carService.GetAllDetailsByFuelId(1);
//carService.GetAllDetailsByPriceRange(800000, 2000000);
//carService.GetAllDetailsByBrandNameContains("opel");
//carService.GetAllDetailsByModelNameContains("astra");
//carService.GetDetailById(1);
//carService.GetAllDetailsByKilometerRange(100000,500000);

ColorService colorService = new ColorService();

//colorService.Add(color);

FuelService fuelService = new FuelService();

//fuelService.Add(fuel);

TransmissionService transmissionService = new TransmissionService();

transmissionService.Add(transmission);

