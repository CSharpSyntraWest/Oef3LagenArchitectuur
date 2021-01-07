using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IBierenDataService
    {
        IList<Bieren> GeefAlleBierenVoorSoort();
    }
}