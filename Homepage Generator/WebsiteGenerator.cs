using System;
using System.Collections.Generic;
using System.Text;

namespace Homepage_Generator
{
    class WebsiteGenerator
    {
        //Data från ett API
        string[] techniquesList = { " C#", "daTAbaser", "WebbuTVeckling ", "clean Code " };
        string[] medelandeList = { "Måndag idrott", "Tisdag musik", "Onsdag utedag", "Torsdag kör", "Fredag ledig" };

        public void header()
        {
            Console.WriteLine("<!DOCTYPE htm >" +
            "           \n<html>" +
            "           \n<body>");
        }

        public void mainPart(string klassnamn)
        {
            Console.WriteLine("     <h1> Välkomna " + klassnamn + "! </h1>");

            foreach (string medelandeItem in this.medelandeList)
            {
                Console.WriteLine("     <p><b> Meddelande: </b> " + medelandeItem + " </p>");
            }

            Console.WriteLine("  <main>");

            foreach (string item in this.techniquesList)
            {
                string kurs = item.Trim().ToLower();
                string newKurs = kurs[0].ToString().ToUpper() + kurs.Substring(1);
                Console.WriteLine("     <p> Kurs om " + newKurs + " </p>");
            }
        }

        public void footer()
        {
            Console.WriteLine("  </main>" +
            "           \n</body>" +
            "           \n</html>");
        }
    }
}
