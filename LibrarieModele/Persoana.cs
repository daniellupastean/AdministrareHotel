namespace LibrarieModele
{
    public class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int CNP_POZ = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;

        public Persoana(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);

            CNP = dateAsArrayOfStrings[CNP_POZ];
            Nume = dateAsArrayOfStrings[NUME];
            Prenume = dateAsArrayOfStrings[PRENUME];

        }

        virtual public string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {Nume} {Prenume}";

            return dateForDisplay;
        }
    }
}
