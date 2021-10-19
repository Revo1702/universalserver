using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaimlerGmbHuCoKGServer.Model
{
    public class HumidValue : ValuesBase
    {
        public override string ToString()
        {
            return $"Luftfeuchtigkeit: {Value}% am {DateAndTime}";
        }
    }
}
