using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareRezervari
    {
        void AddRezervare(Rezervare r);
        void UpdateFisierRezervari(List<Rezervare> rezervari);
        List<Rezervare> GetRezervari();
        Rezervare GetRezervare(int id);
    }
}
