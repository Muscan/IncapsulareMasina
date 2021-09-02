using System;
using static IncapsulareMasina.Masina;

namespace IncapsulareMasina
{
    class Program
    {
        static void Main(string[] args)
        {



            ControllerMasina controller = new ControllerMasina();
            //Masina myCar = new Masina("JMW", true, false, '9', 123);
            //controller.AddCar(myCar);
            //controller.saveToFileTxt();
            //controller.afisareOneCar(myCar);
           

            controller.DeleteCar("JMW");

            controller.saveToFileTxt();

            controller.afisare();






























        }
    }
}
