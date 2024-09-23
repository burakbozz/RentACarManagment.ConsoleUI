using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace RentACarManagement.ConsoleUI.Repository;

public class CarRepository
{
    List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,1,"kiralık",100000,2020,"34 ABC 34","BMW","X5",3000000),
        new Car(2,4,1,1,"kiralık",150000,2021,"34 ABC 35","opel","astra",1000000),
        new Car(3,2,2,2,"dolu",200000,2015,"34 ASD 36","renault","clio 4",600000),
        new Car(4,3,4,3,"dolu",600000,2021,"34 ASD 37","renault","clio 5",1200000),
        new Car(5,3,3,3,"kiralık",800000,2021,"34 JKL 38","renault","capture",1300000),
    };

    List<Color> colors = new List<Color>()
        {
            new Color(1,"White"),
            new Color(2,"Black"),
            new Color(3,"Blue"),
            new Color(4,"Red"),
            new Color(5,"Green")

        };
    List<Fuel> fuels = new List<Fuel>()
        {
            new Fuel(1,"Benzin"),
            new Fuel(2,"Dizel"),
            new Fuel(3,"LPG"),
            new Fuel(4,"Elektirik"),
            new Fuel(5,"Hibrit")

        };
    List<Transmission> transmissions = new List<Transmission>()
        {
            new Transmission(1,"Otamatik"),
            new Transmission(2,"Manuel"),
            new Transmission(3,"Yarı Otamatik"),
            new Transmission(4,"Triptonik"),


        };
    public Car Add(Car created)
    {
        cars.Add(created);
        return created;
    }

    public List<Car> GetAll() 
    { 
        return cars;
    }

    public Car? GetById(int id)
    {
        Car? car1 = null;
        foreach (Car car in cars)
        {
            if (car.Id == id)
            {
                car1 = car;
            }
        }

        if (car1 == null)
        {
            return null;
        }

        return car1;
    }

    public Car? Remove(int id)
    {
        Car? deletedCar = GetById(id);

        if (deletedCar is null)
        {
            return null;
        }
        cars.Remove(deletedCar);
        return deletedCar;
    }

    public Car? Update(int id, Car newCar)
    {
        Car? car = GetById(id);
        if (car is null)
        {
            return null;
        }
        car = newCar;
        return car;
    }

    public List<CarDetailDto> GetDetails()
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName:b.BrandName,
                ModelName:b.ModelName,
                DailyPrice:b.DailyPrice
                
                );

        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            where b.FuelId == fuelId
            join t in transmissions on b.TransmissionId equals t.Id
            

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );
        
        return result.ToList();
        
    }

    public List<CarDetailDto> GetAllDetailsByPriceRange(double min,double max)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id
            where b.DailyPrice >min && b.DailyPrice <max

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );

        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id
            where b.BrandName == brandName

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );

        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id
            where b.ModelName == modelName

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );

        return result.ToList();
    }

    public CarDetailDto? GetDetailById(int id)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id
            where b.Id == id

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );

        return result.FirstOrDefault();
    }

    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min,int max)
    {
        var result =
            from b in cars
            join c in colors on b.ColorId equals c.Id
            join f in fuels on b.FuelId equals f.Id
            join t in transmissions on b.TransmissionId equals t.Id
            where b.KiloMeter > min && b.KiloMeter < max

            select new CarDetailDto(
                Id: b.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: b.CarState,
                KiloMeter: b.KiloMeter,
                ModelYear: b.ModelYear,
                Plate: b.Plate,
                BrandName: b.BrandName,
                ModelName: b.ModelName,
                DailyPrice: b.DailyPrice

                );

        return result.ToList();
    }


}






