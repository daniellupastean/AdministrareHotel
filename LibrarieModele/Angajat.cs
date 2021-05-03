namespace LibrarieModele
{
    public class Angajat : Persoana
    {
        string Functie { get; set; }
        float Salariu { get; set; }

        public Angajat(string _date) : base(_date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');
            Functie = dateAsArrayOfStrings[3];

            if (float.TryParse(dateAsArrayOfStrings[4], out float salariu))
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
