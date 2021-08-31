using System;
using static IncapsulareMasina.Masina;

namespace IncapsulareMasina
{
    class Program
    {
        static void Main(string[] args)
        {

            ControllerMasina control = new ControllerMasina();



            //control.afisare();


            Masina m = new Masina("test",true, true, '2', 1200);

            Console.WriteLine(control.AddCar(m));



            //Console.WriteLine(control.UpdateCar("test", 23333));
            //control.UpdateNumeCar("test", 1000);
           // Console.WriteLine("Masina updatata:" + m.descriereMasina());

            //control.UpdateTransmisieAutomaticMasina("test", false);
           // Console.WriteLine("Masina cu transmisie updatata de la: "+ m.descriereMasina());

            //control.UpdateTransmisieManual("test", false);
            //Console.WriteLine("Masina cu manuala" + m.descriereMasina());

            //control.UpdateNcapMasina("test", '9');
            //Console.WriteLine("Masina cu ncap NOU "+ m.descriereMasina());

            //control.UpdatePret("test", 999999);
            //Console.WriteLine("Pret nou"+"\n"+ m.descriereMasina());

            //Delete
          

            Masina car = new Masina("test1", true, true, '2', 19006);
            Console.WriteLine(control.DeleteCar("test1"));
            control.DeleteCar("test");
            //tbd
            Console.WriteLine("Masina stearsa" + "\n" + m.descriereMasina());






        }
    }
}
