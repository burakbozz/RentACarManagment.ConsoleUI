using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Service;

public class FuelService
{
    FuelRepository fuelRepository = new FuelRepository();
    public void Add(Fuel fuel)
    {
        Fuel created = fuelRepository.Add(fuel);
        Console.WriteLine("Yakıt tipi eklendi : ");
        Console.WriteLine(created);
    }
}
