using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Client : Persoana
    {
        int[] ID_rezervari { get; set; }

        public Client(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            string[] rezervariAsArrayOfStrings = dateAsArrayOfStrings[3].Split('-');
            

            ID_rezervari = new int[rezervariAsArrayOfStrings.Length];
            for(int i = 0; i<ID_rezervari.Length;i++)
            {
                ID_rezervari[i] = int.Parse(rezervariAsArrayOfStrings[i]);
            }
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {Nume} {Prenume}, ";
            foreach(int rezervare in ID_rezervari)
            {
                
                dateForDisplay += $"{rezervare}-";
            }

            dateForDisplay = dateForDisplay.TrimEnd('-');

            return dateForDisplay;
        }
    }
}
