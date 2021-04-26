using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Rezervare
    {
        public static int nrRezervari;
        int id_rezervare;
        string CNP_client;
        int id_camera;
        string checkin_date;
        string checkout_date;

        public Rezervare(string _date)
        {

            id_rezervare = nrRezervari++;

            string[] dateAsArrayOfStrings = _date.Split(',');
            CNP_client = dateAsArrayOfStrings[0];
            int.TryParse(dateAsArrayOfStrings[1], out id_camera);
            checkin_date = dateAsArrayOfStrings[2];
            checkout_date = dateAsArrayOfStrings[3];
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"{id_rezervare}, {CNP_client}, {id_camera}, {checkin_date} - {checkout_date}";

            return dateForDisplay;
        }
    }
}
