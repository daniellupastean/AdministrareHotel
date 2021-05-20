using System;
using System.Collections;
using System.Collections.Generic;
using LibrarieModele;

namespace LibrarieModele
{
    public class Client : Persoana
    {
        int[] ID_rezervari { get; set; }
        public static int IdUltimClient { get; set; } = 0;

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

        static public string HeaderInfo()
        {
            string sf = "{0,-15}{1,-15}{2,-15} {3,-20}";

            return string.Format(sf, "Nume", "Prenume", "CNP", "ID Rezervari");
        }

        public override string ConversieLaSir()
        {
            string sf = "{0,-15}{1,-15}{2,-15} {3,-20}";
            string rezervari = "";
            foreach (int rezervare in ID_rezervari)
            {

                rezervari += $"{rezervare}-";
            }

            rezervari = rezervari.TrimEnd('-');

            return string.Format(sf, Nume, Prenume, CNP, rezervari);
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{CNP},{Nume},{Prenume},";
            foreach (int rezervare in ID_rezervari)
            {
                dateForDisplay += $"{rezervare}-";
            }

            dateForDisplay = dateForDisplay.TrimEnd('-');

            return dateForDisplay;
        }
    }
}
