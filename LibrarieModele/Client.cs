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

        public void Update(string _CNP, string _Nume, string _Prenume, string _ID_rezervari)
        {
            CNP = _CNP;
            Nume = _Nume;
            Prenume = _Prenume;

            string[] rezervariAsArrayOfStrings = _ID_rezervari.Split('-');


            ID_rezervari = new int[rezervariAsArrayOfStrings.Length];
            for (int i = 0; i < ID_rezervari.Length; i++)
            {
                ID_rezervari[i] = int.Parse(rezervariAsArrayOfStrings[i]);
            }
        }







    }
}
