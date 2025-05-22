using NuGet.Protocol.Core.Types;

namespace Projektuppgift.Services
{
    public class CarService
    {

        public static Dictionary<string, List<string>> Cars = new Dictionary<string, List<string>>()
        {
            { "Volvo", new List<string>(){"S90", "V70", "XC30"} },
            { "BMW",  new List<string>(){"X1", "M3"} }
        };
    }

}
