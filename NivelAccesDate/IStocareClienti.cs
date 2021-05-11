using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareClienti
    {
        void AddClient(Client c);
        void UpdateFisierClienti(List<Client> clienti);
        List<Client> GetClienti();
        Client GetClient(string nume, string prenume);
        
    }
}
