namespace LibrarieModele
{
    public class Rezervare
    {
        public static int IdUltimaRezervare { get; set; } = 0;
        public static int NrRezervari { get; set; }
        public int ID_rezervare { get; set; }
        public string CNP_client { get; set; }
        public int ID_camera { get; set; }
        public string Checkin_date { get; set; }
        public string Checkout_date { get; set; }

        public Rezervare(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');
            ID_rezervare = int.Parse(dateAsArrayOfStrings[0]);
            CNP_client = dateAsArrayOfStrings[1];

            if(int.TryParse(dateAsArrayOfStrings[2], out int id))
            {
                ID_camera = id;
            }
            Checkin_date = dateAsArrayOfStrings[3];
            Checkout_date = dateAsArrayOfStrings[4];
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{ID_rezervare}, {CNP_client}, {ID_camera}, {Checkin_date} - {Checkout_date}";

            return dateForDisplay;
        }


        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{ID_rezervare},{CNP_client},{ID_camera},{Checkin_date},{Checkout_date}";

            return dateForDisplay;
        }
    }
}
