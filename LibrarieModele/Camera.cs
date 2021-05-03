namespace LibrarieModele
{
    public class Camera
    {
        public static int IdUltimaCamera { get; set; } = 0;
        public int ID_camera { get; set; }
        public string Denumire { get; set; }
        public float Dimensiune { get; set; }
        public int Etaj { get; set; }
        public string[] Facilitati { get; set; }
        public string Tip { get; set; }
        public float Pret { get; set; }

        public Camera(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            ID_camera = int.Parse(dateAsArrayOfStrings[0]);
            Denumire = dateAsArrayOfStrings[1];
            if (float.TryParse(dateAsArrayOfStrings[2], out float dimensiune))
            {
                Dimensiune = dimensiune;
            }

            if (int.TryParse(dateAsArrayOfStrings[3], out int etaj))
            {
                Etaj = etaj;
            }
            Facilitati = dateAsArrayOfStrings[4].Split('-');
            Tip = dateAsArrayOfStrings[5];

            if (float.TryParse(dateAsArrayOfStrings[6], out float pret))
            {
                Pret = pret;
            }
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{ID_camera}, {Denumire}, {Dimensiune}m2, {Etaj}, ";

            foreach (string facilitate in Facilitati)
                dateForDisplay += $"{facilitate}-";
            dateForDisplay = dateForDisplay.TrimEnd('-');
            dateForDisplay += $", {Tip}, {Pret} lei";

            return dateForDisplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{ID_camera},{Denumire},{Dimensiune},{Etaj},";

            foreach (string facilitate in Facilitati)
                dateForDisplay += $"{facilitate}-";
            dateForDisplay = dateForDisplay.TrimEnd('-');
            dateForDisplay += $",{Tip},{Pret}";

            return dateForDisplay;
        }


        public static bool operator <(Camera c1, Camera c2)
        {

            if (c1.Dimensiune < c2.Dimensiune)
                return true;
            else
                return false;
        }

        public static bool operator >(Camera c1, Camera c2)
        {

            if (c1.Dimensiune > c2.Dimensiune)
                return true;
            else
                return false;
        }

    }
}
