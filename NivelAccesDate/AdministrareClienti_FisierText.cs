using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareClienti_FisierText : IStocareClienti
    {
        string NumeFisierClienti { get; set; }
        

        public AdministrareClienti_FisierText(string numeFisierClienti)
        {
            this.NumeFisierClienti = numeFisierClienti;
            
            Stream sFisierTextClienti = File.Open(numeFisierClienti, FileMode.OpenOrCreate);
            sFisierTextClienti.Close();
           
        }

        #region ZONA METODE PENTRU ADMINISTRARE CLIENTI

        public void AddClient(Client c)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierTextClienti = new StreamWriter(NumeFisierClienti, true))
                {
                    swFisierTextClienti.WriteLine(c.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Clienti. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void UpdateFisierClienti(List<Client> clienti)
        {
            using (StreamWriter swFisierTextClienti = new StreamWriter(NumeFisierClienti, false))
            {
                foreach (Client client in clienti)
                    swFisierTextClienti.WriteLine(client.ConversieLaSir_PentruScriereInFisier());
            }
        }

        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierClienti))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Client clientDinFisier = new Client(line);
                        clienti.Add(clientDinFisier);
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

            return clienti;
        }

        public Client GetClient(string nume, string prenume)
        {

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierClienti))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {

                        Client clientDinFisier = new Client(line);
                        if (clientDinFisier.Nume == nume && clientDinFisier.Prenume == prenume)
                            return clientDinFisier;
                    }
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului Clienti. Mesaj: " + eIO.Message);
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
