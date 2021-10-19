using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DaimlerGmbHuCoKGServer.Model
{
    public class Station
    {
        public string Name;

        public IPAddress IP;

        public List<HumidValue> HumidValues;
        public List<TempValue> TempValues;
        public List<PressureValue> PessureValues;
    }
}
