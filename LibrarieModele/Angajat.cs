using System;

namespace LibrarieModele
{
    public class Angajat : Persoana
    {
        public string Functie { get; set; }
        public float Salariu { get; set; }
        public DateTime DataActualizare { get; set; }
        public static int IdUltimAngajat { get; set; } = 0;
        
        
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int FUNCTIE = 3;
        private const int SALARIU = 4;
        private const int DATA_ACTUALIZARE = 5;



        public Angajat(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);
            Functie = dateAsArrayOfStrings[FUNCTIE];

            if (float.TryParse(dateAsArrayOfStrings[SALARIU], out float salariu))
            {
                Salariu = salariu;
            }
            DataActualizare = DateTime.Parse(dateAsArrayOfStrings[DATA_ACTUALIZARE]);
        }

        static public string HeaderInfo()
        {
            string sf = "{0,-15}{1,-12}{2,-12} {3,-17} {4,-9} {5, 15}";

            return string.Format(sf, "CNP", "Nume", "Prenume", "Functie", "Salariu" , "Data Actualizare");
        }

        public override string ConversieLaSir()
        {
            string sf = "{0,-15}{1,-12}{2,-12} {3,-17} {4,-9} {5, 15}";
            string dateForDisplay = string.Format( sf, CNP, Nume, Prenume,Functie, Salariu, DataActualizare);

            return dateForDisplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{CNP},{Nume},{Prenume},{Functie},{Salariu},{DataActualizare}";

            return dateForDisplay;
        }
    }
}
