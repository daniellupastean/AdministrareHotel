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

        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int ID_CAMERA = 0;
        private const int DENUMIRE = 1;
        private const int DIMENSIUNE = 2;
        private const int ETAJ = 3;
        private const int FACILITATI = 4;
        private const int TIP = 5;
        private const int PRET = 6;
        

        public Camera(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);

            ID_camera = int.Parse(dateAsArrayOfStrings[ID_CAMERA]);
            Denumire = dateAsArrayOfStrings[DENUMIRE];
            if (float.TryParse(dateAsArrayOfStrings[DIMENSIUNE], out float dimensiune))
            {
                Dimensiune = dimensiune;
            }

            if (int.TryParse(dateAsArrayOfStrings[ETAJ], out int etaj))
            {
                Etaj = etaj;
            }

            Facilitati = (FacilitatiCamera)0;
            string[] facilitati = dateAsArrayOfStrings[FACILITATI].Split('-');

            foreach(string facilitate in facilitati)
            {
                Facilitati |= (FacilitatiCamera)int.Parse(facilitate);
            }

            Tip = (TipCamera)int.Parse(dateAsArrayOfStrings[TIP]);

            if (float.TryParse(dateAsArrayOfStrings[PRET], out float pret))
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
