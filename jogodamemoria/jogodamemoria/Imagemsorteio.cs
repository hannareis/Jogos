using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogodamemoria
{
    class Imagemsorteio
    {
        int numerosorteado;

        public int aleatorio(int semente)
        {
            Random random = new Random(semente);


            int sorte;

            numerosorteado = random.Next(0,7);

            sorte = numerosorteado;
            return sorte;
        }


    }

}

