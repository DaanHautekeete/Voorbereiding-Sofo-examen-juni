using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_8.Oef_2
{
    internal class Leerling : Persoonsgegevens
    {
        //variabelen maken
        private string _klas, _volledigeNaam;

        //standaardwaarden geven => constructor
        public Leerling()
        {
            _klas = "onbekend";
            _volledigeNaam = "onbekend";
        }

        //eigenschappen maken
        public string Klas
        {
            get
            {
                return _klas;
            }
            set
            {
                _klas = value;
            }
        }

        public string VolledigeNaam
        {
            get
            {
                return _volledigeNaam;
            }
            set
            {
                _volledigeNaam = value;
            }
        }

        //constructor maken
        public Leerling(string strKlas, string strVolledigeNaam)
        {
            _klas = strKlas;
            _volledigeNaam = strVolledigeNaam;
        }
    }
}
