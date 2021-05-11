using System;
using System.Collections.Generic;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataUtilizator_Consola
{
    class Program
    {
        static void Main()
        {
            List<Client> clienti;
            List<Angajat> angajati;
            List<Camera> camere;
            List<Rezervare> rezervari;

            IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
            IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
            IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();
            IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();

            clienti = adminClienti.GetClienti();
            angajati = adminAngajati.GetAngajati();
            camere = adminCamere.GetCamere();
            rezervari = adminRezervari.GetRezervari();

            int nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
            
            int nrAngajati = angajati.Count;
            Angajat.IdUltimAngajat = nrAngajati;
            
            int nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;
            
            int nrRezervari = rezervari.Count;
            Rezervare.IdUltimaRezervare = nrRezervari;

            string optiune;
            while(true)
            {
                Console.WriteLine("|----- ADMINISTRARE HOTEL -----|\n");
                Console.WriteLine("A-CL. Afisare clienti");
                Console.WriteLine("A-AN. Afisare angajati");
                Console.WriteLine("A-CA. Afisare camere");
                Console.WriteLine("A-RE. Afisare rezervari\n");
                Console.WriteLine("C-CL. Creare si adaugare client");
                Console.WriteLine("C-AN. Creare si adaugare angajat");
                Console.WriteLine("C-CA. Creare si adaugare camera");
                Console.WriteLine("C-RE. Creare si adaugare rezervare\n");
                Console.WriteLine("F-CL. Cauta client dupa nume");
                Console.WriteLine("F-AN. Cauta angajat dupa nume");
                Console.WriteLine("F-CA. Cauta camera dupa id");
                Console.WriteLine("F-RE. Cauta rezervare dupa id\n");
                Console.WriteLine("M-CL. Modifica client dupa nume");
                Console.WriteLine("M-AN. Modifica angajat dupa nume");
                Console.WriteLine("M-CA. Modifica camera dupa id\n");
                Console.WriteLine("M-RE. Modifica rezervare dupa id");
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
                    case "A-RE":
                        AfisareRezervari(rezervari);
                        break;
                    case "C-CL":
                        CitireClientTastatura(adminClienti, clienti);
                        break;
                    case "C-AN":
                        CitireAngajatTastatura(adminAngajati, angajati);
                        break;
                    case "C-CA":
                        CitireCameraTastatura(adminCamere, camere);
                        break;
                    case "C-RE":
                        CitireRezervareTastatura(adminRezervari, rezervari);
                        break;
                    case "F-CL":
                        CautaClient(adminClienti);
                        break;
                    case "F-AN":
                        CautaAngajat(adminAngajati);
                        break;
                    case "F-CA":
                        CautaCamera(adminCamere);
                        break;
                    case "F-RE":
                        CautaRezervare(adminRezervari);
                        break;
                    case "M-CL":
                        UpdateClient(adminClienti, clienti);
                        break;
                    case "M-AN":
                        UpdateAngajat(adminAngajati, angajati);
                        break;
                    case "M-CA":
                        UpdateCamera(adminCamere, camere);
                        break;
                    case "M-RE":
                        UpdateRezervare(adminRezervari, rezervari);
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

        public static void CitireClientTastatura(IStocareClienti adminClienti, List<Client> clienti)
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
            adminClienti.AddClient(new Client(line));
            Console.WriteLine("");
        }

        public static void CautaClient(IStocareClienti adminClienti)
        {
            Console.Write("Introduceti numele clientului cautat: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele clientului cautat: ");
            string prenume = Console.ReadLine();

            Client clientAfisare = adminClienti.GetClient(nume, prenume);
            if (clientAfisare == null)
                Console.WriteLine("Acest client nu a fost gasit in baza de date.");
            else
                Console.WriteLine("\nA fost gasit: " + clientAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateClient(IStocareClienti adminClienti, List<Client> clienti)
        {
            Console.Write("Introduceti numele clientului ale carui informatii vrei sa le modifici: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele clientului: ");
            string prenume = Console.ReadLine();

            Client clientAfisare = adminClienti.GetClient(nume, prenume);
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

            adminClienti.UpdateFisierClienti(clienti);
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


        public static void CitireAngajatTastatura(IStocareAngajati adminAngajati, List<Angajat> angajati)
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
            adminAngajati.AddAngajat(new Angajat(line));
            Console.WriteLine("");
        }

        public static void CautaAngajat(IStocareAngajati adminAngajati)
        {
            Console.Write("Introduceti numele angajatului cautat: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele angajatului cautat: ");
            string prenume = Console.ReadLine();

            Angajat angajatAfisare = adminAngajati.GetAngajat(nume, prenume);
            if (angajatAfisare == null)
                Console.WriteLine("Acest angajat nu a fost gasit in baza de date.");
            else
                Console.WriteLine("\nA fost gasit: " + angajatAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateAngajat(IStocareAngajati adminAngajati, List<Angajat> angajati)
        {
            Console.Write("Introduceti numele angajatului ale carui informatii vrei sa le modifici: ");
            string nume = Console.ReadLine();

            Console.Write("Introduceti prenumele angajatului: ");
            string prenume = Console.ReadLine();
            
            Angajat angajatAfisare = adminAngajati.GetAngajat(nume, prenume);
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

            adminAngajati.UpdateFisierAngajati(angajati);
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


        public static void CitireCameraTastatura(IStocareCamere adminCamere, List<Camera> camere)
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

            Console.Write("Introduceti facilitatile sub forma \"1-2-16\" [ 0=Niciuna, 1=Televizor, 2=Internet, 4=Seif, 8=Jacuzzi, 16=Frigider ]: ");
            string facilitati = Console.ReadLine();

            Console.Write("Introduceti tipul camerei [1-Single, 2 - Dubla, 3-Twin, 4-Matrimoniala, 5-Tripla, 6-Quad] : ");
            string tip = Console.ReadLine();
            
            Console.Write("Introduceti pretul camerei: ");
            string pret = Console.ReadLine();

            string line = $"{id},{denumire},{dimensiune},{etaj},{facilitati},{tip},{pret}";

            camere.Add(new Camera(line));
            adminCamere.AddCamera(new Camera(line));
            Console.WriteLine("");
        }

        public static void CautaCamera(IStocareCamere adminCamere)
        {
            Console.Write("Introduceti ID-ul camerei cautate: ");
            int id = int.Parse(Console.ReadLine());

            Camera cameraAfisare = adminCamere.GetCamera(id);
            if (cameraAfisare == null)
                Console.WriteLine("Aceasta camera nu a fost gasita in baza de date.");
            else
                Console.WriteLine("\nA fost gasita camera: " + cameraAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateCamera(IStocareCamere adminCamere, List<Camera> camere)
        {
            Console.Write("Introdu ID-ul camerei ale carei informatii vrei sa le modifici: ");
            int id = int.Parse(Console.ReadLine());

            Camera cameraAfisare = adminCamere.GetCamera(id);
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
                    Console.Write("Introdu noile facilitati sub forma \"1-2-16\": ");

                    camere[i].Facilitati = (FacilitatiCamera)0;
                    string[] facilitati = Console.ReadLine().Split('-');

                    foreach (string facilitate in facilitati)
                    {
                        camere[i].Facilitati |= (FacilitatiCamera)int.Parse(facilitate);
                    }
                }

                if (modificari.Contains("t"))
                {
                    Console.Write("Introdu noul tip: ");
                    camere[i].Tip = (TipCamera)int.Parse(Console.ReadLine());
                }

                if (modificari.Contains("p"))
                {
                    Console.Write("Introdu noul pret: ");
                    camere[i].Pret = float.Parse(Console.ReadLine());
                }

            }

            adminCamere.UpdateFisierCamere(camere);
        }
        #endregion
        
        #region Metode Rezervari

        public static void AfisareRezervari(List<Rezervare> rezervari)
        {
            Console.WriteLine("Rezervarile sunt:");
            for (int i = 0; i < rezervari.Count; i++)
            {
                Console.WriteLine(((Rezervare)rezervari[i]).ConversieLaSir());
            }
            Console.WriteLine("");
        }


        public static void CitireRezervareTastatura(IStocareRezervari adminRezervari, List<Rezervare> rezervari)
        {
            Console.WriteLine("CITIRE DATE REZERVARE");
            Console.Write("Introduceti ID-ul rezervarii: ");
            string id_rezervare = Console.ReadLine();
            
            Console.Write("Introduceti CNP-ul clientului: ");
            string cnp = Console.ReadLine();

            Console.Write("Introduceti ID-ul camerei: ");
            string id_camera = Console.ReadLine();

            Console.Write("Introduceti data de check-in sub forma \"zz.ll.aaaa\": ");
            string checkin = Console.ReadLine();
            
            Console.Write("Introduceti data de check-out sub forma \"zz.ll.aaaa\": ");
            string checkout = Console.ReadLine();

         
            string line = $"{id_rezervare},{cnp},{id_camera},{checkin},{checkout}";

            rezervari.Add(new Rezervare(line));
            adminRezervari.AddRezervare(new Rezervare(line));
            Console.WriteLine("");
        }

        public static void CautaRezervare(IStocareRezervari adminRezervari)
        {
            Console.Write("Introduceti ID-ul rezervarii cautate: ");
            int id = int.Parse(Console.ReadLine());

            Rezervare rezervareAfisare = adminRezervari.GetRezervare(id);
            if (rezervareAfisare == null)
                Console.WriteLine("Aceasta rezervare nu a fost gasita in baza de date.");
            else
                Console.WriteLine("\nA fost gasita rezervarea: " + rezervareAfisare.ConversieLaSir() + "\n");
        }


        public static void UpdateRezervare(IStocareRezervari adminRezervari, List<Rezervare> rezervari)
        {
            Console.Write("Introdu ID-ul rezervarii ale carei informatii vrei sa le modifici: ");
            int id = int.Parse(Console.ReadLine());

            Rezervare rezervareAfisare = adminRezervari.GetRezervare(id);
            if (rezervareAfisare == null)
                Console.WriteLine("Aceasta rezervare nu a fost gasita in baza de date.");
            else
            {
                Console.WriteLine("\nA fost gasita: " + rezervareAfisare.ConversieLaSir() + "\n");
                Console.WriteLine("Ce modificari vrei sa faci?\n[ r=ID rezervare, c=CNP client, i = ID camera, d=data check-in si check-out, ci=CNP client + ID camera etc ]");
                string modificari = Console.ReadLine();

                int i = 0;
                while (rezervari[i].ID_rezervare != rezervareAfisare.ID_rezervare)
                {
                    i++;
                }
                
                if (modificari.Contains("r"))
                {
                    Console.Write("Introdu noul ID  al rezervarii: ");
                    rezervari[i].ID_rezervare = int.Parse(Console.ReadLine());
                }

                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul CNP al clientului: ");
                    rezervari[i].CNP_client = Console.ReadLine();
                }
                
                if (modificari.Contains("i"))
                {
                    Console.Write("Introdu noul ID al camerei: ");
                    rezervari[i].ID_camera = int.Parse(Console.ReadLine());
                }
                
                if (modificari.Contains("d"))
                {
                    Console.Write("Introduceti noua data de check-in sub forma \"zz.ll.aaaa\": ");
                    rezervari[i].Checkin_date = Console.ReadLine();
                    Console.Write("Introduceti noua data de check-out sub forma \"zz.ll.aaaa\": ");
                    rezervari[i].Checkout_date = Console.ReadLine();
                }

            }

            adminRezervari.UpdateFisierRezervari(rezervari);
        }
        #endregion

    }

}
