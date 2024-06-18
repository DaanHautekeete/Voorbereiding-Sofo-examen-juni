using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voobereiding_SOFO_examen_juni.Hoofdstuk_8.Oef_2
{
    internal class Persoonsgegevens
    {
        //variabelen maken => altijd in kleine letters met een _ ervoor
        private string _voornaam, _familienaam;
        private DateTime _geboortedatum;
        private int _leeftijd;

        //standaardwaarden meegeven => constructor
        public Persoonsgegevens()
        {
            _voornaam = "onbekend";
            _familienaam = "onbekend";
        }

        //eigenschappen maken
        public String Voornaam
        {
            get
            {
                return _voornaam;
            }
            set
            {
                _voornaam = value;
            }
        }

        public String Familienaam
        {
            get
            {
                return _familienaam;
            }
            set
            {
                _familienaam = value;
            }
        }

        public DateTime Geboortedatum
        {
            get
            {
                return _geboortedatum;
            }
            set
            {
                _geboortedatum = value;
            }
        }

        public int Leeftijd
        {
            get
            {
                return _leeftijd;
            }
            set
            {
                _leeftijd = value;
            }
        }

        //constructor maken
        public Persoonsgegevens(string strVoornaam, string strFamilienaam, DateTime dtmGeboortedatum, int intLeeftijd)
        {
            _voornaam = strVoornaam;
            _familienaam = strFamilienaam;
            _geboortedatum = dtmGeboortedatum;
            _leeftijd = intLeeftijd;
        }
    }
}
