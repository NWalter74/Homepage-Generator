using System;
using System.Collections.Generic;
using System.Text;

namespace Homepage_Generator
{
    class WebsiteGenerator
    {
        public WebsiteGenerator(string [] myTechniqueList, string [] myMedelandeList)
        {
            string[] techniqueListAPI = myTechniqueList;

            string[] medelandeListAPI = myMedelandeList;
        }

        public void header()
        {
            Console.WriteLine("<!DOCTYPE htm >" +
            "           \n<html>" +
            "           \n<body>");
        }

        public void mainPart(string klassnamn, string[] techniqueListAPI, string[] medelandeListAPI)
        {
            Console.WriteLine("     <h1> Välkomna " + klassnamn + "! </h1>");

            foreach (string item in techniqueListAPI)
            {
                Console.WriteLine("     <p> Kurs om " + item + " </p>");
            }

            Console.WriteLine("  <main>");
            
            foreach (string medelandeItem in medelandeListAPI)
            {
                Console.WriteLine("     <p><b> Meddelande: </b> " + medelandeItem + " </p>");
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
