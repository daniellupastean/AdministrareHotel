using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Camera
    {
        public static int nrCamere;
        int id_camera;
        string denumire;
        float dimensiune;
        int etaj;
        string[] facilitati;
        string tip;
        float pret;

        public Camera(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(',');

            id_camera = nrCamere++;
            denumire = dateAsArrayOfStrings[0];
            float.TryParse(dateAsArrayOfStrings[1], out dimensiune);
            int.TryParse(dateAsArrayOfStrings[2], out etaj);
            facilitati = dateAsArrayOfStrings[3].Split('-');
            tip = dateAsArrayOfStrings[4];
            float.TryParse(dateAsArrayOfStrings[5], out pret);
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{id_camera}, ";
            dateForDisplay += denumire;
            dateForDisplay += $", {dimensiune}m2";
            dateForDisplay += $", {etaj}";
            dateForDisplay += ", ";
            foreach(string facilitate in facilitati)
                dateForDisplay += $"{facilitate}+";
            dateForDisplay = dateForDisplay.TrimEnd('+');
            dateForDisplay += $", {tip}";
            dateForDisplay += $", {pret} lei";


            return dateForDisplay;
        }


        public static bool operator <(Camera c1, Camera c2)
        {

            if (c1.dimensiune < c2.dimensiune)
                return true;
            else
                return false;
        }

        public static bool operator >(Camera c1, Camera c2)
        {

            if (c1.dimensiune > c2.dimensiune)
                return true;
            else
                return false;
        }
    }
}
