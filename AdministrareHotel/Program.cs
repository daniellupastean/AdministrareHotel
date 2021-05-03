using System;
using System.Collections;
using System.Collections.Generic;
using LibrarieModele;
using NivelAccesDate;

namespace AdministrareHotel
{
    class Program
    {
        static void Main()
        {
            List<Client> clienti = new List<Client>();

            IStocareData adminHotel = StocareFactory.GetAdministratorStocare();

            clienti = adminHotel.GetClienti();
            int nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;

            Camera.NrCamere = 0;

            string optiune;
            while(true)
            {
                Console.WriteLine("|----- ADMINISTRARE HOTEL -----|\n");
                Console.WriteLine("A. Afisare clienti");
                Console.WriteLine("C. Creare si adaugare client");
                Console.WriteLine("F. Cauta client dupa nume");
                Console.WriteLine("M. Modifica client dupa nume");
                Console.WriteLine("X. Inchidere program");
                Console.Write("\nAlegeti o optiune: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        AfisareClienti(clienti);
                        break;
                    case "C":
                        Client clientTastatura = CitireClientTastatura();
                        clienti.Add(clientTastatura);
                        adminHotel.AddClient(clientTastatura);
                        Console.WriteLine("");
                        break;
                    case "F":
                        CautaClient(adminHotel);
                        break;
                    case "M":
                        UpdateClient(adminHotel, clienti);
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
        public static void AfisareClienti(List<Client> clienti)
        {
            Console.WriteLine("Clientii sunt:");
            for (int i = 0; i < clienti.Count; i++)
            {
                Console.WriteLine(((Client)clienti[i]).ConversieLaSir());
            }
            Console.WriteLine("");
        }
        public static Client CitireClientTastatura()
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
            
            Client s = new Client(line);

            return s;
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
            Console.Write("Introduceti numele clientului ale carui informatii vreti sa le modificati: ");
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

                string _CNP = clientAfisare.CNP;
                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul CNP: ");
                    _CNP = Console.ReadLine();
                }

                string _nume = clientAfisare.Nume;
                if (modificari.Contains("n"))
                {
                    Console.Write("Introdu noul nume: ");
                    _nume = Console.ReadLine();
                }

                string _prenume = clientAfisare.Prenume;
                if (modificari.Contains("c"))
                {
                    Console.Write("Introdu noul prenume: ");
                    _prenume = Console.ReadLine();
                }

                int  i = 0;
                while(clienti[i].CNP!=clientAfisare.CNP)
                {
                    i++;
                }
                clienti[i].CNP = _CNP;
                clienti[i].Nume = _nume;
                clienti[i].Prenume = _prenume;
            }

            adminHotel.UpdateFisierClienti(clienti);
        }
    }
    
}
