using NivelAccesDate;
using System.Configuration;

namespace AdministrareHotel
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_CLIENTI = "NumeFisierClienti";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";
        private const string NUME_FISIER_CAMERE = "NumeFisierCamere";
        private const string NUME_FISIER_REZERVARI = "NumeFisierRezervari";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierClienti = ConfigurationManager.AppSettings[NUME_FISIER_CLIENTI];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];
            var numeFisierCamere = ConfigurationManager.AppSettings[NUME_FISIER_CAMERE];
            var numeFisierRezervari = ConfigurationManager.AppSettings[NUME_FISIER_REZERVARI];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareHotel_FisiereText($"{numeFisierClienti}.{formatSalvare}", $"{numeFisierAngajati}.{formatSalvare}", $"{numeFisierCamere}.{formatSalvare}", $"{numeFisierRezervari}.{formatSalvare}");
                }
            }

            return null;
        }
    }
}
