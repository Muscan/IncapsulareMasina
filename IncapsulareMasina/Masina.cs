using System;
using System.Collections.Generic;
using System.Text;

namespace IncapsulareMasina
{
    class Masina
    {
        private string nume;
        private bool automatic;
        private bool manual;
        private char ncap;
        private double pret;

        public Masina(string nume, bool automatic, char ncap, double pret)
        {
           // Console.WriteLine("Consturctor cu cutie automata 4 params");
            this.nume = nume;
            this.automatic = automatic;
            this.ncap = ncap;
            this.pret = pret;
        }
        public Masina(string nume, bool manual, double pret)
        {
            //Console.WriteLine("Constructor cu cutie manuala si 3 param");
            this.nume = nume;
            this.manual = manual;
            this.pret = pret;
        }

        public Masina(string nume, bool automatic, bool manual, char ncap, double pret)
        {
            //Console.WriteLine("Toti constructorii pentru masina");
            {
                this.nume = nume;
                this.automatic = automatic;
                this.manual = manual;
                this.ncap = ncap;
                this.pret = pret;

            }
        }

        public Masina(string nume)
            
        {
            //Console.WriteLine("1 parametru nume");
            {
                this.nume = nume;
            }
        }
        public Masina()
        {
            //Console.WriteLine("Empty constructor");
        }

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getNume()
        {
            return this.nume;
        }
        public void setAutomatic(bool automatic)
        {
            this.automatic = automatic;
        }
        public bool getAutomatic()
        {
            return this.automatic;
        }
        public void setManual(bool manual)
        {
            this.manual = manual;

        }
        public bool getManual()
        {
            return this.manual;
        }

        public void setNcap(char ncap)
        {
            this.ncap = ncap;
        }

        public char getNcap()
        {
            return this.ncap;
        }

        public void setPret(double pret)
        {
            this.pret = pret;
        }
        public double getPret()
        {
            return this.pret;
        }

        public string descriereMasina()
        {
            string descriereMasina = "";

            descriereMasina += "Nume masina: " + this.nume + "\n";
            descriereMasina += "Automatic: " + this.automatic + "\n";
            descriereMasina += "Manual: " + this.manual + "\n";
            descriereMasina += "Stele ncap siguranta: " + this.ncap + "\n";
            descriereMasina += "Pret: " + this.pret + "\n";
            return descriereMasina;
        }



        //todo functie care transforma proprietatile intr-un string 



        public String toSave()
        {


            return  nume + "," + automatic + "," + manual + "," + ncap + "," + pret;

        }
    }

}
