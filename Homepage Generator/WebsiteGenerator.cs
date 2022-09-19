using System;
using System.Collections.Generic;
using System.Text;

namespace Homepage_Generator
{
    class WebsiteGenerator
    {
        private string[] techniqueListAPI;
        private string[] medelandeListAPI;
        private string className;
        public WebsiteGenerator(string myClassName, string [] myTechniqueList, string [] myMedelandeList)
        {
            this.className = myClassName;
            this.techniqueListAPI = myTechniqueList;
            this.medelandeListAPI = myMedelandeList;
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

            for (int i = 0; i < techniqueListAPI.Length; i++)
            {
                techniqueListAPI[i] = techniqueListAPI[i].Trim().ToLower();
                techniqueListAPI[i] = techniqueListAPI[i][0].ToString().ToUpper() + techniqueListAPI[i].Substring(1);
            }

            foreach (string techniquesItem in this.techniqueListAPI)
            {
                Console.WriteLine("     <p> Kurs om " + techniquesItem + " </p>");
            }

            Console.WriteLine("  <main>");
            
            foreach (string medelandeItem in this.medelandeListAPI)
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

        public void printPage()
        {
            header();
            mainPart("klass 5B", techniqueListAPI, medelandeListAPI);
            footer();
        }
    }
}
