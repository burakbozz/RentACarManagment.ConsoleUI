using RentACarManagement.ConsoleUI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Repository;

public class FuelRepository
{
    List<Fuel> fuels = new List<Fuel>()
        {
            new Fuel(1,"Benzin"),
            new Fuel(2,"Dizel"),
            new Fuel(3,"LPG"),
            new Fuel(4,"Elektirik"),
            new Fuel(5,"Hibrit")

        };

    public Fuel Add(Fuel created)
    {
        fuels.Add(created);
        return created;
    }
}
