using System.Collections.Generic;
using System.Linq;

namespace EauClairesSalon.Models;

public class Stylist
{
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Speciality { get; set; }

    //connect clients
    //public Client client { get; set; }
}