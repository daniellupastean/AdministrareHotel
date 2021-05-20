using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareCamere_FisierText : IStocareCamere
    {        
        string NumeFisierCamere { get; set; }

        public AdministrareCamere_FisierText(string numeFisierCamere)
        {
            
            this.NumeFisierCamere = numeFisierCamere;
            
            
            Stream sFisierTextCamere = File.Open(numeFisierCamere, FileMode.OpenOrCreate);
            sFisierTextCamere.Close();
            
        }

        #region ZONA METODE PENTRU ADMINISTRARE CAMERE

        public void AddCamera(Camera c)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierTextCamere = new StreamWriter(NumeFisierCamere, true))
                {
                    swFisierTextCamere.WriteLine(c.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Camere. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void UpdateFisierCamere(List<Camera> camere)
        {
            using (StreamWriter swFisierTextCamere = new StreamWriter(NumeFisierCamere, false))
            {
                foreach (Camera camera in camere)
                    swFisierTextCamere.WriteLine(camera.ConversieLaSir_PentruScriereInFisier());
            }
        }

        public List<Camera> GetCamere()
        {
            List<Camera> camere = new List<Camera>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierCamere))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Camera cameraDinFisier = new Camera(line);
                        camere.Add(cameraDinFisier);
                        Camera.IdUltimaCamera = cameraDinFisier.ID_camera;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Camere. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return camere;
        }

        public Camera GetCamera(int id)
        {

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierCamere))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Camera cameraDinFisier = new Camera(line);
                        if (cameraDinFisier.ID_camera == id)
                            return cameraDinFisier;
                    }
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Camere. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }


            return null;

        }
        #endregion

    }
}
