using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
          animal peixe =  new animal();
            peixe.Idade = 2;
            Console.WriteLine(peixe.Idade);

            animal gato = new animal();

            Console.ReadKey();
        }
    }
}
