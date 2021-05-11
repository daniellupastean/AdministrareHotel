using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareCamere
    {
        void AddCamera(Camera c);
        void UpdateFisierCamere(List<Camera> camere);
        List<Camera> GetCamere();
        Camera GetCamera(int id);
        
    }
}
