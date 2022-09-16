using System;
using System.Collections.Generic;

namespace Homepage_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fleraMedelandet = true;

            //Svar från ett API
            string[] techniques = { " C#", "daTAbaser", "WebbuTVeckling ", "clean Code " };

            List<string> medelandenList = new List<string>();

            void header()
            {
                Console.WriteLine("<!DOCTYPE htm >" +
                "           \n<html>" +
                "           \n<body>");
            }

            void mainPart(string klassnamn, List<string> medelandetList)
            {
                Console.WriteLine("     <h1> Välkomna " + klassnamn + "! </h1>");

                foreach (string medelandeItem in medelandenList)
                {
                    Console.WriteLine("     <p><b> Meddelande: </b> " + medelandeItem + " </p>");
                }

                Console.WriteLine("  <main>");

                foreach (string item in techniques)
                {
                    string kurs = item.Trim().ToLower();
                    string newKurs = kurs[0].ToString().ToUpper() + kurs.Substring(1);
                    Console.WriteLine("     <p> Kurs om " + newKurs + " </p>");
                }
            }

            void footer()
            {
                Console.WriteLine("  </main>" +
                "           \n</body>" +
                "           \n</html>");
            }

            void SparaMedelandenIEnList()
            {
                Console.Write("Skriv in ditt medelande: ");
                medelandenList.Add(Console.ReadLine());

                while (fleraMedelandet == true)
                {
                    Console.Write("Vill du lägga till fler? (svara med j eller n) ");
                    string svar = Console.ReadLine();

                    if (svar == "j")
                    {
                        Console.Write(": ");
                        medelandenList.Add(Console.ReadLine());
                    }
                    else
                    {
                        fleraMedelandet = false;
                    }
                    Console.WriteLine();
                }
            }

            SparaMedelandenIEnList();
            header();
            mainPart("klass 5B", medelandenList);
            footer();
        }
    }
}
