using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareAngajati
    {
        void AddAngajat(Angajat a);
        void UpdateFisierAngajati(List<Angajat> angajati);
        List<Angajat> GetAngajati();
        Angajat GetAngajat(string nume, string prenume);
        
    }
}
