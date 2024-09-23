using RentACarManagement.ConsoleUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarManagement.ConsoleUI.Repository;

public class TransmissionRepository
{
    List<Transmission> transmissions = new List<Transmission>()
        {
            new Transmission(1,"Otamatik"),
            new Transmission(2,"Manuel"),
            new Transmission(3,"Yarı Otamatik"),
            new Transmission(4,"Triptonik"),
            

        };

    public Transmission Add(Transmission created)
    {
        transmissions.Add(created);
        return created;
    }
}
