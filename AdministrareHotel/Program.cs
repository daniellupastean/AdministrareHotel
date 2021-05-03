using System;
using System.Collections.Generic;
using LibrarieModele;
using NivelAccesDate;

namespace AdministrareHotel
{
    class Program
    {
        static void Main()
        {
            List<Client> clienti;
            List<Angajat> angajati;
            List<Camera> camere;

            IStocareData adminHotel = StocareFactory.GetAdministratorStocare();

            clienti = adminHotel.GetClienti();
            angajati = adminHotel.GetAngajati();
            camere = adminHotel.GetCamere();

            int nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
            
            int nrAngajati = angajati.Count;
            Angajat.IdUltimAngajat = nrAngajati;
            
            int nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;

            string optiune;
            while(true)
            {
                Console.WriteLine("|----- ADMINISTRARE HOTEL -----|\n");
                Console.WriteLine("A-CL. Afisare clienti");
                Console.WriteLine("A-AN. Afisare angajati");
                Console.WriteLine("A-CA. Afisare camere");
                Console.WriteLine("C-CL. Creare si adaugare client");
                Console.WriteLine("C-AN. Creare si adaugare angajat");
                Console.WriteLine("C-CA. Creare si adaugare camera");
                Console.WriteLine("F-CL. Cauta client dupa nume");
                Console.WriteLine("F-AN. Cauta angajat dupa nume");
                Console.WriteLine("F-CA. Cauta camera dupa id");
                Console.WriteLine("M-CL. Modifica client dupa nume");
                Console.WriteLine("M-AN. Modifica angajat dupa nume");
                Console.WriteLine("M-CA. Modifica camera dupa id");
                Console.WriteLine("X. Inchidere program");

                Console.Write("\nAlegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A-CL":
                        AfisareClienti(clienti);
                        break;
                    case "A-AN":
                        AfisareAngajati(angajati);
                        break;
                    case "A-CA":
                        AfisareCamere(camere);
                        break;
                    case "C-CL":
                        CitireClientTastatura(adminHotel, clienti);
                        break;
                    case "C-AN":
                        CitireAngajatTastatura(adminHotel, angajati);
                        break;
                    case "C-CA":
                        CitireCameraTastatura(adminHotel, camere);
                        break;
                    case "F-CL":
                        CautaClient(adminHotel);
                        break;
                    case "F-AN":
                        CautaAngajat(adminHotel);
                        break;
                    case "F-CA":
                        CautaCamera(adminHotel);
                        break;
                    case "M-CL":
                        UpdateClient(adminHotel, clienti);
                        break;
                    case "M-AN":
                        UpdateAngajat(adminHotel, angajati);
                        break;
                    case "M-CA":
                        UpdateCamera(adminHotel, camere);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
                Console.WriteLine("\nApasa orice tasta pentru a reveni la meniul principal.");
                Console.ReadKey();
                Console.Clear();
            };
        }


        #region Metode Clienti
        public static void AfisareClienti(List<Client> clienti)
        {
            Console.WriteLine("Clientii sunt:");
            for (int i = 0; i < clienti.Count; i++)
            {
                Console.WriteLine(((Client)clienti[i]).ConversieLaSir());
            }
            Console.WriteLine("");
        }

        public static void CitireClientTastatura(IStocareData adminHotel, List<Client> clienti)
        {
            Console.WriteLine("CITIRE DATE CLIENT");
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele: ");
            string prenume = Console.ReadLine();

            Console.Write("Introduceti CNP-ul: ");
            string CNP = Console.ReadLine();

            Console.Write("Introduceti ID-urile rezervarilor facute de acest client sub forma \"ID1-ID2-ID3....\": ");
            string ID_rezervari = Console.ReadLine();

            string line = $"{CNP},{nume},{prenume},{ID_rezervari}";

            clienti.Add(new Client(line));
            adminHotel.AddClient(new Client(line));
            Console.WriteLine("");
        }

        public static void CautaClient(IStocareData adminHotel)
        {
            Console.Write("Introduceti numele clientului cautat: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele clientului cautat: ");
            string prenume = Console.ReadLine();

            Client clientAfisare = adminHotel.GetClient(nume, prenume);
            if (clientAfisare == null)
                Console.WriteLine("Acest client nu a fost gasit in baza de date.");
            else
                Console.WriteLine("\nA fost gasit: " + clientAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateClient(IStocareData adminHotel, List<Client> clienti)
        {
            Console.Write("Introduceti numele clientului ale carui informatii vrei sa le modifici: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele clientului: ");
            string prenume = Console.ReadLine();

            Client clientAfisare = adminHotel.GetClient(nume, prenume);
            if (clientAfisare == null)
                Console.WriteLine("Client Negasit");
            else
            {
                Console.WriteLine("\nA fost gasit: " + clientAfisare.ConversieLaSir() + "\n");
                Console.WriteLine("Ce modificari vrei sa faci? (n=nume, p=prenume, c=CNP, np=nume+prenume etc)");
                string modificari = Console.ReadLine();

                int i = 0;
                while (clienti[i].CNP != clientAfisare.CNP)
                {
                    i++;
                }
                
                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul CNP: ");
                    clienti[i].CNP = Console.ReadLine();
                }
               
                if (modificari.Contains("n"))
                {
                    Console.Write("Introdu noul nume: ");
                    clienti[i].Nume = Console.ReadLine();
                }

                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul prenume: ");
                    clienti[i].Prenume = Console.ReadLine();
                }
            }

            adminHotel.UpdateFisierClienti(clienti);
        }
        #endregion

        #region Metode Angajati

        public static void AfisareAngajati(List<Angajat> angajati)
        {
            Console.WriteLine("Angajatii sunt:");
            for (int i = 0; i < angajati.Count; i++)
            {
                Console.WriteLine(((Angajat)angajati[i]).ConversieLaSir());
            }
            Console.WriteLine("");
        }


        public static void CitireAngajatTastatura(IStocareData adminHotel, List<Angajat> angajati)
        {
            Console.WriteLine("CITIRE DATE ANGAJAT");
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele: ");
            string prenume = Console.ReadLine();

            Console.Write("Introduceti CNP-ul: ");
            string CNP = Console.ReadLine();

            Console.Write("Introduceti functia: ");
            string functie = Console.ReadLine();

            Console.Write("Introduceti salariul: ");
            string salariu = Console.ReadLine();

            string line = $"{CNP},{nume},{prenume},{functie},{salariu}";

            angajati.Add(new Angajat(line));
            adminHotel.AddAngajat(new Angajat(line));
            Console.WriteLine("");
        }

        public static void CautaAngajat(IStocareData adminHotel)
        {
            Console.Write("Introduceti numele angajatului cautat: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele angajatului cautat: ");
            string prenume = Console.ReadLine();

            Angajat angajatAfisare = adminHotel.GetAngajat(nume, prenume);
            if (angajatAfisare == null)
                Console.WriteLine("Acest angajat nu a fost gasit in baza de date.");
            else
                Console.WriteLine("\nA fost gasit: " + angajatAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateAngajat(IStocareData adminHotel, List<Angajat> angajati)
        {
            Console.Write("Introduceti numele angajatului ale carui informatii vrei sa le modifici: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele angajatului: ");
            string prenume = Console.ReadLine();
            
            Angajat angajatAfisare = adminHotel.GetAngajat(nume, prenume);
            if (angajatAfisare == null)
                Console.WriteLine("Angajat Negasit");
            else
            {
                Console.WriteLine("\nA fost gasit: " + angajatAfisare.ConversieLaSir() + "\n");
                Console.WriteLine("Ce modificari vrei sa faci?\n[ n=nume, p=prenume, c=CNP, f=functie, s=salariu, np=nume+prenume etc ]");
                string modificari = Console.ReadLine();

                int i = 0;
                while (angajati[i].CNP != angajatAfisare.CNP)
                {
                    i++;
                }
                
                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul CNP: ");
                    angajati[i].CNP = Console.ReadLine();
                }

                if (modificari.Contains("n"))
                {
                    Console.Write("Introdu noul nume: ");
                    angajati[i].Nume = Console.ReadLine();
                }
                
                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul prenume: ");
                    angajati[i].Prenume = Console.ReadLine();
                }

                if (modificari.Contains("f"))
                {
                    Console.Write("Introdu noua functie: ");
                    angajati[i].Functie = Console.ReadLine();
                }

                if (modificari.Contains("s"))
                {
                    Console.Write("Introdu noul salariu: ");
                    angajati[i].Salariu = float.Parse(Console.ReadLine());
                }

            }

            adminHotel.UpdateFisierAngajati(angajati);
        }
        #endregion

        #region Metode Camere

        public static void AfisareCamere(List<Camera> camere)
        {
            Console.WriteLine("Camerele sunt:");
            for (int i = 0; i < camere.Count; i++)
            {
                Console.WriteLine(((Camera)camere[i]).ConversieLaSir());
            }
            Console.WriteLine("");
        }


        public static void CitireCameraTastatura(IStocareData adminHotel, List<Camera> camere)
        {
            Console.WriteLine("CITIRE DATE CAMERA");
            Console.Write("Introduceti ID-ul: ");
            string id = Console.ReadLine();
            
            Console.Write("Introduceti denumirea: ");
            string denumire = Console.ReadLine();

            Console.Write("Introduceti dimensiunea: ");
            string dimensiune = Console.ReadLine();

            Console.Write("Introduceti etaj-ul: ");
            string etaj = Console.ReadLine();

            Console.Write("Introduceti facilitatile sub forma \"televizor-internet-seif\": ");
            string facilitati = Console.ReadLine();

            Console.Write("Introduceti tipul camerei: ");
            string tip = Console.ReadLine();
            
            Console.Write("Introduceti pretul camerei: ");
            string pret = Console.ReadLine();

            string line = $"{id},{denumire},{dimensiune},{etaj},{facilitati},{tip},{pret}";

            camere.Add(new Camera(line));
            adminHotel.AddCamera(new Camera(line));
            Console.WriteLine("");
        }

        public static void CautaCamera(IStocareData adminHotel)
        {
            Console.Write("Introduceti ID-ul camerei cautate: ");
            int id = int.Parse(Console.ReadLine());

            Camera cameraAfisare = adminHotel.GetCamera(id);
            if (cameraAfisare == null)
                Console.WriteLine("Aceasta camera nu a fost gasita in baza de date.");
            else
                Console.WriteLine("\nA fost gasita camera: " + cameraAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateCamera(IStocareData adminHotel, List<Camera> camere)
        {
            Console.Write("Introdu ID-ul camerei ale carei informatii vrei sa le modifici: ");
            int id = int.Parse(Console.ReadLine());

            Camera cameraAfisare = adminHotel.GetCamera(id);
            if (cameraAfisare == null)
                Console.WriteLine("Aceasta camera nu a fost gasita in baza de date.");
            else
            {
                Console.WriteLine("\nA fost gasit: " + cameraAfisare.ConversieLaSir() + "\n");
                Console.WriteLine("Ce modificari vrei sa faci?\n[ i=id, n=nume, e=etaj, f=facilitati, t=tip, p=pret, ne=nume+etaj etc ]");
                string modificari = Console.ReadLine();

                int i = 0;
                while (camere[i].ID_camera != cameraAfisare.ID_camera)
                {
                    i++;
                }
                
                if (modificari.Contains("i"))
                {
                    Console.Write("Introdu noul ID: ");
                    camere[i].ID_camera = int.Parse(Console.ReadLine());
                }

                if (modificari.Contains("n"))
                {
                    Console.Write("Introdu noul nume: ");
                    camere[i].Denumire = Console.ReadLine();
                }
                
                if (modificari.Contains("d"))
                {
                    Console.Write("Introdu noua dimensiune(in m2): ");
                    camere[i].Denumire = Console.ReadLine();
                }
                
                if (modificari.Contains("e"))
                {
                    Console.Write("Introdu noul etaj: ");
                    camere[i].Etaj = int.Parse(Console.ReadLine());
                }

                if (modificari.Contains("f"))
                {
                    Console.Write("Introdu noile facilitati sub forma \"televizor-internet-seif\": ");
                    camere[i].Facilitati = Console.ReadLine().Split('-');
                }

                if (modificari.Contains("t"))
                {
                    Console.Write("Introdu noul tip: ");
                    camere[i].Tip = Console.ReadLine();
                }

                if (modificari.Contains("p"))
                {
                    Console.Write("Introdu noul pret: ");
                    camere[i].Pret = float.Parse(Console.ReadLine());
                }

            }

            adminHotel.UpdateFisierCamere(camere);
        }
        #endregion

    }

}
