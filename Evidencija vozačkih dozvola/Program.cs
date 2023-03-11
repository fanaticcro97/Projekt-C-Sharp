using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencija_vozačkih_dozvola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unos;
            Vozac Vozac = new Vozac("Goran", "Roso", "12345678911", new DateTime(2020, 12, 12), new DateTime(2019 - 10 - 18));
            Vozac.DodajKategoriju("B");
            Vozac.DodajKategoriju("A");
            Vozac.DodajKategoriju("C");

           
            //Vozac.IzbrisiKategoriju("Truck");


            do
            {
                Console.WriteLine("1 Dodavanje novog vozača");
                Console.WriteLine("2 Azuriranje postojeceg vozača");
                Console.WriteLine("3 Ispis svih vozača");
                Console.WriteLine("4 Ispis vozača sa važećom vozačkom dozvolom");
                Console.WriteLine("5 Ispis vozača sa isteklom vozačkom dozvolom");
                Console.WriteLine("6 Prekid rada programa");
                Console.WriteLine("");
                Console.Write("Odaberite izbornik(1-6): ");
                int.TryParse(Console.ReadLine(), out unos);

                switch (unos)
                {
                    case 1:
                        string ime;
                        string prezime;
                        string OIB;
                        DateTime datumIzdavanjaVozackeDozvole;
                        DateTime datumIstekaVozackeDozvole;
                        Console.Write("Ime vozača: ");
                        ime = Console.ReadLine();
                        Console.Write("Prezime vozača: ");
                        prezime = Console.ReadLine();
                        Console.Write("OIB vozača: ");
                        OIB = Console.ReadLine();
                        Console.Write("Datum izdavanja vozačke dozvole: ");
                        datumIzdavanjaVozackeDozvole = DateTime.Parse(Console.ReadLine());
                        Console.Write("Datum isteka vozačke dozvole: ");
                        datumIstekaVozackeDozvole = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        break;

                    case 2: break;

                    case 3: break;

                    case 4: break;

                    case 5: break;

                    case 6: break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Unesite valjanu opciju.");
                        break;
                }
            }
            while (unos != 6) ;
            Console.ReadKey();           
        }    
    }


        class Vozac
        {
            public string ime { get; set; }
            public string prezime { get; set; }
            public string OIB { get; set; }
            public DateTime datumIzdavanjaVozackeDozvole { get; set; }
            public DateTime datumIstekaVozackeDozvole { get; set; }
            private HashSet<string> _popisKategorija
            { get; 
              set; 
            }


            public Vozac(string ime, string prezime, string OIB, DateTime datumIzdavanjaVozackeDozvole, DateTime datumIstekaVozackeDozvole)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.OIB = OIB;
                this.datumIzdavanjaVozackeDozvole = datumIzdavanjaVozackeDozvole;
                this.datumIstekaVozackeDozvole = datumIstekaVozackeDozvole;
                this._popisKategorija = new HashSet<string>();  
            }

            public void DodajKategoriju(string kategorija)
            {
                _popisKategorija.Add(kategorija);   
            }

            public void IzbrisiKategoriju(string kategorija)
            {
                _popisKategorija.Remove(kategorija);
            }


    }
    
}
