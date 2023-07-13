using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic.Models
{
    public static class Extensao
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}