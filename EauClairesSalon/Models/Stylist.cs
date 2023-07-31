using System.Collections.Generic;
using System.Linq;
using System;

namespace EauClairesSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public List<Client> Clients { get; set; }
    }
}