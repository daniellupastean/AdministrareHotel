using NivelAccesDate;
using System.Configuration;

namespace InterfataUtilizator_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_CLIENTI = "NumeFisierClienti";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";
        private const string NUME_FISIER_CAMERE = "NumeFisierCamere";
        private const string NUME_FISIER_REZERVARI = "NumeFisierRezervari";
        
        public static IStocareClienti GetAdministratorStocareClienti()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierClienti = ConfigurationManager.AppSettings[NUME_FISIER_CLIENTI];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareClienti_FisierText($"{numeFisierClienti}.{formatSalvare}");
                }
            }

            return null;
        }
        
        public static IStocareAngajati GetAdministratorStocareAngajati()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareAngajati_FisierText($"{numeFisierAngajati}.{formatSalvare}");
                }
            }

            return null;
        }

        public static IStocareCamere GetAdministratorStocareCamere()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierCamere = ConfigurationManager.AppSettings[NUME_FISIER_CAMERE];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareCamere_FisierText($"{numeFisierCamere}.{formatSalvare}");
                }
            }

            return null;
        }

        public static IStocareRezervari GetAdministratorStocareRezervari()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierRezervari = ConfigurationManager.AppSettings[NUME_FISIER_REZERVARI];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new AdministrareRezervari_FisierText($"{numeFisierRezervari}.{formatSalvare}");
                }
            }

            return null;
        }
    }
}
