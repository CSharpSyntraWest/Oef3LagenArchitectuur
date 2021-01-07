using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Bier
    {
        public int BierNr { get; set; }
        public string Naam { get; set; }
        public int SoortNr { get; set; }
        public double Alcohol { get; set; }
    }
}
