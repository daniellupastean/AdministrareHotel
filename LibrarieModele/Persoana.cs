namespace LibrarieModele
{
    public class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        public Persoana(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            CNP = dateAsArrayOfStrings[0];
            Nume = dateAsArrayOfStrings[1];
            Prenume = dateAsArrayOfStrings[2];

        }

        virtual public string ConversieLaSir()
        {
            string dateForDisplay = $"{CNP}, {Nume} {Prenume}";

            return dateForDisplay;
        }
    }
}
