namespace LibrarieModele
{
    public class Angajat : Persoana
    {
        public string Functie { get; set; }
        public float Salariu { get; set; }
        public static int IdUltimAngajat { get; set; } = 0;

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

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{CNP},{Nume},{Prenume},{Functie},{Salariu}";

            return dateForDisplay;
        }
    }
}
