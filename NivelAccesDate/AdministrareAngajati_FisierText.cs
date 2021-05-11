using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareAngajati_FisierText : IStocareAngajati
    {
        string NumeFisierAngajati { get; set; }


        public AdministrareAngajati_FisierText(string numeFisierAngajati)
        {            
            this.NumeFisierAngajati = numeFisierAngajati; 

            Stream sFisierTextAngajati = File.Open(numeFisierAngajati, FileMode.OpenOrCreate);
            sFisierTextAngajati.Close();
            
        }

        #region ZONA METODE PENTRU ADMINISTRARE ANGAJATI

        public void AddAngajat(Angajat a)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierTextAngajati = new StreamWriter(NumeFisierAngajati, true))
                {
                    swFisierTextAngajati.WriteLine(a.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Angajati. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void UpdateFisierAngajati(List<Angajat> angajati)
        {
            using (StreamWriter swFisierTextAngajati = new StreamWriter(NumeFisierAngajati, false))
            {
                foreach (Angajat angajat in angajati)
                    swFisierTextAngajati.WriteLine(angajat.ConversieLaSir_PentruScriereInFisier());
            }
        }

        public List<Angajat> GetAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierAngajati))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajat angajatDinFisier = new Angajat(line);
                        angajati.Add(angajatDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return angajati;
        }

        public Angajat GetAngajat(string nume, string prenume)
        {

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierAngajati))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Angajat angajatDinFisier = new Angajat(line);
                        if (angajatDinFisier.Nume == nume && angajatDinFisier.Prenume == prenume)
                            return angajatDinFisier;
                    }
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Angajati. Mesaj: " + eIO.Message);
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
