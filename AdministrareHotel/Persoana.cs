using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Persoana
    {
        protected string nume;
        protected string prenume;
        protected string CNP;

        public Persoana(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            nume = dateAsArrayOfStrings[0];
            prenume = dateAsArrayOfStrings[1];
            CNP = dateAsArrayOfStrings[2];
            
        }

        virtual public string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {nume} {prenume}";

            return dateForDisplay;
        }
    }
}
