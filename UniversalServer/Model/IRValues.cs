using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaimlerGmbHuCoKGServer.Model
{
    public class IRValues : ValuesBase
    {
        int _value;
        
        public int Value { get => _value; set => _value = value; }
       
    }
}
