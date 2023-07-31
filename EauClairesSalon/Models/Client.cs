using System;
using System.Collections.Generic;
using System.Linq;


namespace EauClairesSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int StylistId { get; set; }

        public Stylist Stylist { get; set; }
    }
}