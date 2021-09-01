using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IncapsulareMasina
{
    class ControllerMasina
    {
        private List<Masina> masini;//referinta obiectului


        public ControllerMasina()
        {
            masini = new List<Masina>();

            load();
        }

        public void afisare()
        {

            for (int i = 0; i < masini.Count; i++)
            {

                Console.WriteLine(masini[i].descriereMasina());
            }
        }

        //functie ce returneaza masina cu pretul minim
        public Masina pretMinim()
        {
            Masina minima = masini[0];

            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getPret() < minima.getPret())
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

        public int pozitieMasina(string marca)
        {

            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getNume().Equals(marca))
                {
                    return i;
                }
            }

            return -1;
        }


        //todo o functie ce primeste ca parametru o masina si rretuneaza true daca o dauga sau false daca nu see poate adauga


        public bool AddCar(Masina masina)
        {

            int poz = pozitieMasina(masina.getNume());

            if (poz == -1)
            {

                this.masini.Add(masina);
                return true;
            }
            return false;
        }

        public bool UpdateNumeCar(string nume, double pret)
        {

            int p = pozitieMasina(nume);

            if (p != -1)
            {
                masini[p].setPret(pret);
                return true;
            }
            return false;

        }

        public bool UpdateTransmisieAutomaticMasina(string nume, bool IsAutomatic)
        {
            int p = pozitieMasina(nume);
            if (p != -1)
            {
                masini[p].setAutomatic(false);
                return true;
            }
            return false;
        }

        public bool UpdateTransmisieManual(string nume, bool manual)
        {
            int p = pozitieMasina(nume);
            if (p != -1)
            {
                masini[p].setManual(false);
                return true;
            }
            return false;
        }

        public char UpdateNcapMasina(string nume, char ncap)
        {
            char c = ' ';
            int p = pozitieMasina(nume);
            if (p != -1)
            {
                masini[p].setNcap(ncap);
                c = ncap;
            }
            return ncap;
        }

        public double UpdatePret(string nume, double pret)
        {
            double pretNou = 0;
            int p = pozitieMasina(nume);

            if (p != -1)
            {
                masini[p].setPret(pret);
                pretNou = pret;
            }
            return pret;

        }

        //delete car.Marca-> sterg masina Nume
        public bool DeleteCar(string masina)
        {

            int p = pozitieMasina(masina);
            if (p != -1)
            {
                this.masini.RemoveAt(p);
                return true;

            }
            return false;

        }

        public void load()
        {

            StreamReader read = new StreamReader(@"..masini.txt");

            String line = "";

            while ((line = read.ReadLine()) != "")//citeste linie cu linie
            {


                String[] proprietati = line.Split(",");//imparte linia la ,
                //asociere parametrii cu pozitia in fisier

                String nume = proprietati[0];

                bool automatic = Boolean.Parse(proprietati[1]);

                bool manual = Boolean.Parse(proprietati[2]);

                char ncap = proprietati[3][0];

                double pret = Double.Parse(proprietati[3]);


                Masina masina = new Masina(nume, automatic, manual, ncap, pret);


                masini.Add(masina);

            }

            read.Close();




        }


        public string toSaveAll()
        {
            string tot = "";

            for (int i = 0; i < masini.Count; i++)
            {

                tot += masini[i].toSave() + "\n";
            }


            return tot;
        }


        public void save()
        {

            StreamWriter write = new StreamWriter(@"\masini.txt");


            write.WriteLine(this.toSaveAll());


            write.Close();
        }

    }
}
