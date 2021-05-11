using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareRezervari_FisierText : IStocareRezervari
    {
        string NumeFisierRezervari { get; set; }

        public AdministrareRezervari_FisierText(string numeFisierRezervari)
        {
            this.NumeFisierRezervari = numeFisierRezervari;

            Stream sFisierTextRezervari = File.Open(numeFisierRezervari, FileMode.OpenOrCreate);
            sFisierTextRezervari.Close();

        }

        #region ZONA METODE PENTRU ADMINISTRARE REZERVARI

        public void AddRezervare(Rezervare r)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierTextRezervari = new StreamWriter(NumeFisierRezervari, true))
                {
                    swFisierTextRezervari.WriteLine(r.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Rezervari. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void UpdateFisierRezervari(List<Rezervare> rezervari)
        {
            using (StreamWriter swFisierTextRezervari = new StreamWriter(NumeFisierRezervari, false))
            {
                foreach (Rezervare rezervare in rezervari)
                    swFisierTextRezervari.WriteLine(rezervare.ConversieLaSir_PentruScriereInFisier());
            }
        }

        public List<Rezervare> GetRezervari()
        {
            List<Rezervare> rezervari = new List<Rezervare>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierRezervari))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Rezervare rezervareDinFisier = new Rezervare(line);
                        rezervari.Add(rezervareDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Rezervari. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return rezervari;
        }

        public Rezervare GetRezervare(int id)
        {

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierRezervari))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Rezervare rezervareDinFisier = new Rezervare(line);
                        if (rezervareDinFisier.ID_rezervare == id)
                            return rezervareDinFisier;
                    }
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Rezervari. Mesaj: " + eIO.Message);
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
