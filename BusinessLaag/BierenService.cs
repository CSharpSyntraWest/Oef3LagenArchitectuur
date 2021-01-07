using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BusinessLaag
{
    public class BierenService
    {
        public IList<Bier> GeefAlleBierenVoorSoort()
        {
            IBierenDataService bierenDataservice = new BierenDataService();
            var result = bierenDataservice.GeefAlleBierenVoorSoort();
            return null;//Dit moet later uit de DAL komen
        }
    }
}
