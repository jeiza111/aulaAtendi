using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class animal
    {
        private int idade;
        bool vivo = false;
        public int Idade
        {
            get
            {
                if (vivo)
                    return idade;
                else
                    return 0;
            }
            set
            {
                if (value > 0)
                    idade = value;
            }
            
        }



    }
}
