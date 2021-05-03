namespace LibrarieModele
{
    public class Rezervare
    {
        public static int NrRezervari { get; set; }
        int ID_rezervare { get; set; }
        string CNP_client { get; set; }
        int ID_camera { get; set; }
        string Checkin_date { get; set; }
        string Checkout_date { get; set; }

        public Rezervare(string _date)
        {

            ID_rezervare = NrRezervari++;

            string[] dateAsArrayOfStrings = _date.Split(',');
            CNP_client = dateAsArrayOfStrings[0];

            if(int.TryParse(dateAsArrayOfStrings[1], out int id))
            {
                ID_camera = id;
            }
            Checkin_date = dateAsArrayOfStrings[2];
            Checkout_date = dateAsArrayOfStrings[3];
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{ID_rezervare}, {CNP_client}, {ID_camera}, {Checkin_date} - {Checkout_date}";

            return dateForDisplay;
        }
    }
}
