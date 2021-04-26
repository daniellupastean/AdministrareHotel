using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Client : Persoana
    {
        int[] id_rezervari;

        public Client(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            string[] rezervariAsArrayOfStrings = dateAsArrayOfStrings[3].Split('-');
            

            id_rezervari = new int[rezervariAsArrayOfStrings.Length];
            for(int i = 0; i<id_rezervari.Length;i++)
            {
                id_rezervari[i] = int.Parse(rezervariAsArrayOfStrings[i]);
            }
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {nume} {prenume}, ";
            foreach(int rezervare in id_rezervari)
            {
                
                dateForDisplay += $"{rezervare}-";
            }

            dateForDisplay = dateForDisplay.TrimEnd('-');

            return dateForDisplay;
        }
    }
}
