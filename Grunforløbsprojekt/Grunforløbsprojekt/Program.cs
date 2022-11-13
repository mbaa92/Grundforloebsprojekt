using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunforløbsprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable til at bygge kasser
            //t= top, m=midte, n=nederst
            //v= venstre, h=højre
            string tvHjoerne = "\x250c";
            string thHjoerne = "\x2510";
            string nvHjoerne = "\x2514";
            string nhHjoerne = "\x2518";
            string Lodret = "\x2502";
            string Vandret = "\x2500";
            string mvHjoerne = "\x251C";
            string Kryds = "\x253c";
            string mhHjoerne = "\x2524";
            string tmHjoerne = "\x252c";
            string nmHjoerne = "\x2534";

            //styrer højde og bredde 
            int hoejde=10; //sæt til 10
            int bredde=40; //sæt til 40, max 56

            int tlf;

            string HovedValg; //holder styr på brugerens valg i hovedmenuen
            string tilbage;

            string ButikValg; //holder styr på brugerens valg i butiksmenuen
           
            int AntalTelt;
            int AntalMadras;
            int AntalSovepose;
            double Total;

            do
            {
                Console.WriteLine("Indtast:");
                Console.WriteLine("I for information om festivalpladsen");
                Console.WriteLine("B for webbutikken");

                HovedValg = Console.ReadLine().ToUpper();

                switch (HovedValg)
                {
                    case "I":
                        do
                        {
                            Console.WriteLine("Indtast tlf nr.");
                            tlf = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();                            

                            //Styrer første vandrette linje
                            Console.SetCursorPosition(4, 4);
                            Console.Write(tvHjoerne);
                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }

                            Console.Write(tmHjoerne);

                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }
                            Console.Write(thHjoerne);


                            //Laver 3 lodrette linjer
                            for (int i = 0; i < hoejde; i++)
                            {
                                Console.SetCursorPosition(4, 5 + i);
                                Console.Write(Lodret);
                                for (int j = 0; j < bredde; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(Lodret);
                                for (int j = 0; j < bredde; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(Lodret);
                            }

                            //Laver midterste vandrette linje
                            Console.SetCursorPosition(4, 5 + hoejde);
                            Console.Write(mvHjoerne);
                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }

                            Console.Write(Kryds);

                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }
                            Console.Write(mhHjoerne);

                            //laver 3 lodrette linjer under midten
                            for (int i = 0; i < hoejde; i++)
                            {
                                Console.SetCursorPosition(4, 6 + hoejde + i);
                                Console.Write(Lodret);
                                for (int j = 0; j < bredde; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(Lodret);
                                for (int j = 0; j < bredde; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(Lodret);
                            }

                            //laver sidste vandrette linje
                            Console.SetCursorPosition(4, 6 + 2 * hoejde);
                            Console.Write(nvHjoerne);
                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }

                            Console.Write(nmHjoerne);

                            for (int i = 0; i < bredde; i++)
                            {
                                Console.Write(Vandret);
                            }
                            Console.Write(nhHjoerne);

                            //cursor position skal ændres manuelt
                            Console.SetCursorPosition(60, 20);
                            Console.Write("Vareudlevering");

                            if (tlf >= 10000000 && tlf < 40000000)
                            {
                                //plads 1 (1,1)
                                Console.SetCursorPosition(15, 9);
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write("Du skal slå lejr op her");
                                Console.ResetColor();
                                //plads 2 (2,1)
                                Console.SetCursorPosition(16, 20);
                                Console.Write("Plads 2");
                                //plads 3 (1,2)
                                Console.SetCursorPosition(60, 9);
                                Console.Write("Plads 3");
                            }

                            else if (tlf >= 40000000 && tlf < 70000000)
                            {
                                //plads 1 (1,1)
                                Console.SetCursorPosition(15, 9);
                                Console.Write("Plads 1");

                                //plads 2 (2,1)
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(16, 20);
                                Console.Write("Du skal slå lejr op her");
                                Console.ResetColor();
                                //plads 3 (1,2)
                                Console.SetCursorPosition(60, 9);
                                Console.Write("Plads 3");
                            }

                            else if (tlf >= 70000000 && tlf < 100000000)
                            {
                                //plads 1 (1,1)
                                Console.SetCursorPosition(15, 9);
                                Console.Write("Plads 1");

                                //plads 2 (2,1)               
                                Console.SetCursorPosition(16, 20);
                                Console.Write("Plads 2");

                                //plads 3 (1,2)
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(60, 9);
                                Console.Write("Du skal slå lejr op her");
                                Console.ResetColor();
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt tlf. nr.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ønsker du at komme tilbage til hovedmenuen (J/N)"); 
                            tilbage = Console.ReadLine().ToUpper();
                        } while (tilbage != "J");
                        break;
                    case "B":
                        //Variable sættes til nul så der ikke overføres noget fra en tidligere kunde
                        AntalMadras = 0;
                        AntalSovepose = 0;
                        AntalTelt = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Vælg hvad du vil købe. Alle varer udleveres hos vareudleveringen");
                            Console.WriteLine("Tryk (afslut med enter):");
                            Console.WriteLine("T\tfor\tTelte\t\tPris:\t350,75 kr");
                            Console.WriteLine("L\tfor\tLuftmadrasser\tPris:\t255,00 kr");
                            Console.WriteLine("S\tfor\tSoveposer\tPris:\t150,50 kr");
                            Console.WriteLine("R\tfor\tDen samlede regning");
                            Console.WriteLine("V\tfor\tVejledning til vareudlevering");
                            Console.WriteLine("Q\tfor\tAt afslutte indkøb");

                            ButikValg = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (ButikValg)
                            {
                                case "T":
                                    Console.WriteLine("Indtast hvor mange telte du ønsker at købe, 350,75 kr per stk");
                                    AntalTelt = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Du har valgt at købe {0} telte, hvilket kommer til at koste {1:N2} kr", AntalTelt, AntalTelt * 350.75);
                                    Console.WriteLine("Teltene skal hentes ved vareudleveringen");
                                    Console.ReadKey();
                                    break;
                                case "L":
                                    Console.WriteLine("Indtast hvor mange luftmadrasser du ønsker at købe, 255,00 kr per stk");
                                    AntalMadras = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Du har valgt at købe {0} luftmadrasser, hvilket kommer til at koste {1:N2} kr", AntalMadras, AntalMadras * 255);
                                    Console.WriteLine("Luftmadrasserne skal afhentes ved vareudleveringen");
                                    Console.ReadKey();
                                    break;
                                case "S":
                                    Console.WriteLine("Indtast hvor mange soveposer du ønsker at købe, 150,50 kr per stk");
                                    AntalSovepose = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Du har valgt at købe {0} soveposer, hvilket kommer til at koste {1:N2} kr", AntalSovepose, AntalSovepose * 150.50);
                                    Console.WriteLine("Soveposerne skal afhentes ved vareudleveringen");
                                    Console.ReadKey();
                                    break;
                                case "R":
                                    Total = AntalTelt * 350.75 + AntalMadras * 255 + AntalSovepose * 150.5;
                                    Console.WriteLine("Regning:");
                                    Console.WriteLine("--------------------------------------------------------------------------");
                                    Console.WriteLine("Telte:\t\t{0} stk a 350,75 kr\t\t{1:N2} kr", AntalTelt, AntalTelt * 350.75);
                                    Console.WriteLine("Luftmadrasser:\t{0} stk a 255,00 kr\t\t{1:N2} kr", AntalMadras, AntalMadras * 255);
                                    Console.WriteLine("Soveposer:\t{0} stk a 150,50 kr\t\t{1:N2} kr", AntalSovepose, AntalSovepose * 150.50);
                                    Console.WriteLine("--------------------------------------------------------------------------");
                                    Console.WriteLine("Pris ialt:\t\t\t\t\t{0:N2} kr", Total);
                                    Console.WriteLine("\nTryk på en tast for at komme tilbage");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "V":
                                    Console.Clear();
                                    Console.WriteLine("Vejledning til vareudlevering");

                                    //Styrer første vandrette linje
                                    Console.SetCursorPosition(4, 4);
                                    Console.Write(tvHjoerne);
                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }

                                    Console.Write(tmHjoerne);

                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }
                                    Console.Write(thHjoerne);


                                    //Laver 3 lodrette linjer
                                    for (int i = 0; i < hoejde; i++)
                                    {
                                        Console.SetCursorPosition(4, 5 + i);
                                        Console.Write(Lodret);
                                        for (int j = 0; j < bredde; j++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(Lodret);
                                        for (int j = 0; j < bredde; j++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(Lodret);
                                    }

                                    //Laver midterste vandrette linje
                                    Console.SetCursorPosition(4, 5 + hoejde);
                                    Console.Write(mvHjoerne);
                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }

                                    Console.Write(Kryds);

                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }
                                    Console.Write(mhHjoerne);

                                    //laver 3 lodrette linjer under midten
                                    for (int i = 0; i < hoejde; i++)
                                    {
                                        Console.SetCursorPosition(4, 6 + hoejde + i);
                                        Console.Write(Lodret);
                                        for (int j = 0; j < bredde; j++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(Lodret);
                                        for (int j = 0; j < bredde; j++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write(Lodret);
                                    }

                                    //laver sidste vandrette linje
                                    Console.SetCursorPosition(4, 6 + 2 * hoejde);
                                    Console.Write(nvHjoerne);
                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }

                                    Console.Write(nmHjoerne);

                                    for (int i = 0; i < bredde; i++)
                                    {
                                        Console.Write(Vandret);
                                    }
                                    Console.Write(nhHjoerne);

                                    //plads 1 (1,1)
                                    Console.SetCursorPosition(15, 9);
                                    Console.Write("Plads 1");

                                    //plads 2 (2,1)               
                                    Console.SetCursorPosition(16, 20);
                                    Console.Write("Plads 2");

                                    //plads 3 (1,2)

                                    Console.SetCursorPosition(60, 9);
                                    Console.Write("Plads 3");


                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.SetCursorPosition(60, 20);
                                    Console.Write("Vareudlevering");
                                    Console.ResetColor();

                                    Console.ReadKey();
                                    break;
                               
                            }
                        } while (ButikValg != "Q");
                        break;
                    default:
                        Console.WriteLine("Din indtastning var ikke blandt mulighederne");
                        Console.ReadKey();
                        break;                     

                }
                //Sørger for, at beskeden kun kommer, når kunden har været igennem information eller butik
                if (HovedValg == "B" || HovedValg == "I") 
                {
                    //background color -> clear farver hele konsolvinduet
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(40, 15);
                    Console.WriteLine("God fornøjelse med festivallen!");

                    Console.ReadKey();
                    Console.ResetColor();
                }
                Console.Clear();

            } while (true); //While (true) laver et uendeligt loop
            

        }
    }
}
