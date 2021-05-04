using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddClient(Client c);
        void UpdateFisierClienti(List<Client> clienti);
        List<Client> GetClienti();
        Client GetClient(string nume, string prenume);
        
        void AddAngajat(Angajat a);
        void UpdateFisierAngajati(List<Angajat> angajati);
        List<Angajat> GetAngajati();
        Angajat GetAngajat(string nume, string prenume);
        
        void AddCamera(Camera c);
        void UpdateFisierCamere(List<Camera> camere);
        List<Camera> GetCamere();
        Camera GetCamera(int id);
        
        void AddRezervare(Rezervare r);
        void UpdateFisierRezervari(List<Rezervare> rezervari);
        List<Rezervare> GetRezervari();
        Rezervare GetRezervare(int id);
    }
}
