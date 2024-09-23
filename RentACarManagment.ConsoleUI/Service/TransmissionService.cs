using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Service;

public class TransmissionService
{
    TransmissionRepository transmissionRepository = new TransmissionRepository();
    public void Add(Transmission transmission)
    {
        Transmission created = transmissionRepository.Add(transmission);
        Console.WriteLine("vites tipi eklendi : ");
        Console.WriteLine(created);
    }
}
