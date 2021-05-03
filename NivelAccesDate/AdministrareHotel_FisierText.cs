using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareHotel_FisiereText : IStocareData
    {
        string NumeFisierClienti { get; set; }
        string NumeFisierAngajati { get; set; }
        string NumeFisierCamere { get; set; }
        string NumeFisierRezervari { get; set; }

        public AdministrareHotel_FisiereText(string numeFisierClienti, string numeFisierAngajati, string numeFisierCamere, string numeFisierRezervari)
        {
            this.NumeFisierClienti = numeFisierClienti;
            this.NumeFisierAngajati = numeFisierAngajati;
            this.NumeFisierCamere = numeFisierCamere;
            this.NumeFisierRezervari = numeFisierRezervari;

            Stream sFisierTextClienti = File.Open(numeFisierClienti, FileMode.OpenOrCreate);
            sFisierTextClienti.Close();
            Stream sFisierTextAngajati = File.Open(numeFisierAngajati, FileMode.OpenOrCreate);
            sFisierTextAngajati.Close();
            Stream sFisierTextCamere = File.Open(numeFisierCamere, FileMode.OpenOrCreate);
            sFisierTextCamere.Close();
            Stream sFisierTextRezervari = File.Open(numeFisierRezervari, FileMode.OpenOrCreate);
            sFisierTextRezervari.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        // ZONA METODE PENTRU ADMINISTRARE CLIENTI

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


        // ZONA METODE PENTRU ADMINISTRARE ANGAJATI

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
        
        
        
        // ZONA METODE PENTRU ADMINISTRARE CAMERE

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
    }
}
