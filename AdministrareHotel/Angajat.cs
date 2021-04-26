using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Angajat : Persoana
    {
        string functie;
        float salariu;

        public Angajat(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');
            functie = dateAsArrayOfStrings[3];
            float.TryParse(dateAsArrayOfStrings[4], out salariu);
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {nume} {prenume}, {functie}, {salariu}";

            return dateForDisplay;
        }
    }

    
}
