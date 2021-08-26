using System;
using System.Collections.Generic;
using System.Text;

namespace IncapsulareMasina
{
    class ControllerMasina
    {
        private List<Masina> masini;//referinta obiectului


        public ControllerMasina()
        {

            
            masini = new List<Masina>();//Initializare obiect nou

            //10 masini


            Masina masina1 = new Masina("Audi", true, 1400);//declarare obiecte
            Masina masina2 = new Masina("VW", true, '5', 4000);
            Masina masina3 = new Masina("Suzuki", false, true, '1', 1000);
            Masina masina4 = new Masina("Mazda", true, true, '9', 15000);
            Masina masina5 = new Masina("Atelaj");
            Masina masina6 = new Masina("Tir", true, 100000);
            Masina masina7 = new Masina("Tico");
            Masina masina8 = new Masina("Mercedes", true, '5', 50000);
            Masina masina9 = new Masina("SKoda", true, 1000);
            Masina masina10 = new Masina("opel", true, '4', 5000);

   

            masini.Add(masina1);
            masini.Add(masina2);
            masini.Add(masina3);
            masini.Add(masina4);
            masini.Add(masina5);
            masini.Add(masina6);
            masini.Add(masina7);
            masini.Add(masina8);
            masini.Add(masina9);
            masini.Add(masina10);
        }

        public void afisare()
        {

            for(int i = 0; i < masini.Count; i++)
            {

                Console.WriteLine(masini[i].descriereMasina());
            }
        }

        //functie ce returneaza masina cu pretul minim
        public Masina  pretMinim()
        {
            Masina minima = masini[0];


           

            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getPret() <minima.getPret())
                {
                    minima = masini[i];
                }
            }

            return minima;

        }

        public Masina pretMaxim()
        {
            Masina pretMaxim = masini[0];
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getPret() > pretMaxim.getPret())
                {
                    pretMaxim = masini[i];
                }
            }
            return pretMaxim;
        }

        public void masiniAutomate()
        {
          
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getAutomatic() == true)
                {
                    Console.WriteLine(masini[i].descriereMasina());
                }
            }
           
        }

      
        //todo marca masinii si returnezi pozitia lui

        public int  pozitieMasina(string  marca)  
        {
          
             for(int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getNume().Equals(marca))
                {
                    return i;
                }
            }

            return -1;
        }


    }
}
