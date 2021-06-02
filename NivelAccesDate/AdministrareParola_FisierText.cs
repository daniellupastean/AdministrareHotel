using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareParola_FisierText : IStocareParola
    {
        string NumeFisierParola { get; set; }

        public AdministrareParola_FisierText(string numeFisierParola)
        {
            this.NumeFisierParola = numeFisierParola;

            Stream sFisierTextParola = File.Open(numeFisierParola, FileMode.OpenOrCreate);
            sFisierTextParola.Close();

        }

        #region ZONA METODE PENTRU ADMINISTRARE PAROLA

        public void SetPassword(string password)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierTextRezervari = new StreamWriter(NumeFisierParola, false))
                {
                    swFisierTextRezervari.WriteLine(Password.Encrypt(password));
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

        
        public string GetPassword()
        {

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisierParola))
                {
                    string line;
                    if((line = sr.ReadLine()) != null)
                            return Password.Decrypt(line);
                    
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Parola. Mesaj: " + eIO.Message);
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
