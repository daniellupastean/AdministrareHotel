using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrareHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera.nrCamere = 0;

            Camera c1 = new Camera("Room 001,60,1,televizor-internet-baie,dubla,300.5");
            Camera c2 = new Camera("Room 001,50,1,televizor-internet-baie,dubla,300.5");

            Console.WriteLine($"Camera c1 este mai mare decat camera c2? Raspuns: {c1 > c2}");
            Console.WriteLine(c1.ConversieLaSir());

            Persoana p1 = new Persoana("Lupastean,Daniel,5003939292929");
            Console.WriteLine(p1.ConversieLaSir());

            Angajat a1 = new Angajat("Cosmin,Popescu,5033433492929,receptioner,3000");
            Console.WriteLine(a1.ConversieLaSir());

            Client cl1 = new Client("Alexandru,Ionescu,5923893289898,34-432-3323-223-2323");
            Console.WriteLine(cl1.ConversieLaSir());

            Rezervare r1 = new Rezervare("5923893289898,1,20/10/2020,22/10/2020");
            Console.WriteLine(r1.ConversieLaSir());

            Console.ReadKey();
        }
    }
}
