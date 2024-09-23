using RentACarManagement.ConsoleUI.Model;
using RentACarManagement.ConsoleUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Service;

public class ColorService
{
    ColorRepository colorRepository = new ColorRepository();
    public void Add(Color color)
    {
        Color created = colorRepository.Add(color);
        Console.WriteLine("Renk eklendi : ");
        Console.WriteLine(created);
    }
}
