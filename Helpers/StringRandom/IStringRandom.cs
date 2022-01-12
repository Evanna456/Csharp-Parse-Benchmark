using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Parse_Benchmark.Helpers.StringRandom
{
    interface IStringRandom
    {
        string generateAlphanumeric(int number);

        string generateNumber(int number);
    }
}
