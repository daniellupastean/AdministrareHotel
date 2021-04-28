using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Persoana
    {
        protected string Nume { get; set; }
        protected string Prenume { get; set; }
        protected string CNP { get; set; }

        public Persoana(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            Nume = dateAsArrayOfStrings[0];
            Prenume = dateAsArrayOfStrings[1];
            CNP = dateAsArrayOfStrings[2];
            
        }

        virtual public string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {Nume} {Prenume}";

            return dateForDisplay;
        }
    }
}
