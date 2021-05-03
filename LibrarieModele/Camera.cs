namespace LibrarieModele
{
    public class Camera
    {
        public static int NrCamere { get; set; }
        int ID_camera { get; set; }
        string Denumire { get; set; }
        float Dimensiune { get; set; }
        int Etaj { get; set; }
        string[] Facilitati { get; set; }
        string Tip { get; set; }
        float Pret { get; set; }

        public Camera(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            ID_camera = NrCamere++;
            Denumire = dateAsArrayOfStrings[0];
            if (float.TryParse(dateAsArrayOfStrings[1], out float dimensiune))
            {
                Dimensiune = dimensiune;
            }

            if (int.TryParse(dateAsArrayOfStrings[2], out int etaj))
            {
                Etaj = etaj;
            }
            Facilitati = dateAsArrayOfStrings[3].Split('-');
            Tip = dateAsArrayOfStrings[4];

            if (float.TryParse(dateAsArrayOfStrings[5], out float pret))
            {
                Pret = pret;
            }
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{ID_camera}, ";
            dateForDisplay += Denumire;
            dateForDisplay += $", {Dimensiune}m2";
            dateForDisplay += $", {Etaj}";
            dateForDisplay += ", ";
            foreach (string facilitate in Facilitati)
                dateForDisplay += $"{facilitate}+";
            dateForDisplay = dateForDisplay.TrimEnd('+');
            dateForDisplay += $", {Tip}";
            dateForDisplay += $", {Pret} lei";


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
