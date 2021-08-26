using System;
using static IncapsulareMasina.Masina;

namespace IncapsulareMasina
{
    class Program
    {
        static void Main(string[] args)
        {

            ControllerMasina control = new ControllerMasina();



            Masina m = control.pretMinim();
           

            //Console.WriteLine(m.descriereMasina());
            
            Masina max = control.pretMaxim();

            //Console.WriteLine(max.descriereMasina());

            control.masiniAutomate();
      
          
            
            
        }
    }
}
