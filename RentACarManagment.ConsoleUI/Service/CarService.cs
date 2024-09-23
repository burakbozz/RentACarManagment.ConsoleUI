using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Model.Dtos;
using RentACarManagement.ConsoleUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Service;

public class CarService
{
    CarRepository carRepository = new CarRepository();

    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void Add(Car car)
    {
        Car created = carRepository.Add(car);
        Console.WriteLine("Araba eklendi : ");
        Console.WriteLine(created);
    }

    public void GetById(int id) 
    {
        Car? car =carRepository.GetById(id);
        if(car is null)
        {
            Console.WriteLine($"aradığınız id ye ait araba bulunamadı{id}");
            return;
        }
        Console.WriteLine(car);
    }
    
    public void Remove(int id) 
    {
        Car? deletedCar = carRepository.Remove(id);
        if (deletedCar is null)
        {
            Console.WriteLine("Aradığınız kitap bulunamadı(Zaten Yok)");
            return;
        }
        Console.WriteLine(deletedCar);
    }

    public void Update(int id , Car car)
    { 
        carRepository.Update(id, car);
        Console.WriteLine($"{id} numaralı Araba Güncellendi. {car}");
    }

    public void GetDetails()
    {
        List<CarDetailDto> cars = carRepository.GetDetails();
        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }
    }
    public void GetAllDetailsByFuelId(int fuelId)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByFuelId(1);
        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }
    }

    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByPriceRange(min, max);
        cars.ForEach(x => Console.WriteLine(x));
    }
    public void GetAllDetailsByBrandNameContains(string brandName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByBrandNameContains(brandName);
        cars.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByModelNameContains(modelName);
        cars.ForEach(x => Console.WriteLine(x));
    }

    public void GetDetailById(int id)
    {
        CarDetailDto? car = carRepository.GetDetailById(id);
        if (car is null)
        {
            Console.WriteLine($"aradığınız id ye ait araba bulunamadı{id}");
            return;
        }
        Console.WriteLine(car);
    }
    public void GetAllDetailsByKilometerRange(int min, int max)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByKilometerRange(min, max);
        cars.ForEach(x => Console.WriteLine(x));
    }
}
