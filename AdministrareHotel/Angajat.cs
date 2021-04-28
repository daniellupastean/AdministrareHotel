using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Angajat : Persoana
    {
        string Functie { get; set; }
        float Salariu { get; set; }

        public Angajat(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');
            Functie = dateAsArrayOfStrings[3];

            float salariu;
            if(float.TryParse(dateAsArrayOfStrings[4], out salariu))
            {
                Salariu = salariu;
            }
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {Nume} {Prenume}, {Functie}, {Salariu}";

            return dateForDisplay;
        }
    }

    
}
