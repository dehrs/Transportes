using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class TanqueException :ArgumentException
    {
       public TanqueException()
        {
            Console.WriteLine("Quantidade incorreta");
        }
    }

}
