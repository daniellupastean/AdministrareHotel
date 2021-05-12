namespace LibrarieModele
{
    public class Camera
    {
        public static int IdUltimaCamera { get; set; } = 0;
        public int ID_camera { get; set; }
        public string Denumire { get; set; }
        public float Dimensiune { get; set; }
        public int Etaj { get; set; }
        public FacilitatiCamera Facilitati { get; set; }
        public TipCamera Tip { get; set; }
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

            Facilitati = (FacilitatiCamera)0;
            string[] facilitati = dateAsArrayOfStrings[4].Split('-');

            foreach(string facilitate in facilitati)
            {
                Facilitati |= (FacilitatiCamera)int.Parse(facilitate);
            }

            Tip = (TipCamera)int.Parse(dateAsArrayOfStrings[5]);

            if (float.TryParse(dateAsArrayOfStrings[6], out float pret))
            {
                Pret = pret;
            }
        }

        public string ConversieLaSir()
        {
            string sf = "{0,-4}{1,-15}{2,6} {3,-3} {4,3}  {5,-30}{6,-13}{7,6} {8, -4}";
           
            return string.Format(sf, ID_camera, Denumire, Dimensiune, "m2", Etaj, Facilitati, Tip, Pret, "lei");
        }

        static public string HeaderInfo()
        {
            string sf = "{0,-4}{1,-15}{2,-8} {3,4} {4,-28}  {5,-14}{6,6}";

            return string.Format(sf, "ID", "Denumire", "Dimensiune", "Etaj", "Facilitati", "Tip", "Pret");
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{ID_camera},{Denumire},{Dimensiune},{Etaj},{(int)Facilitati},{(int)Tip},{Pret}";

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
