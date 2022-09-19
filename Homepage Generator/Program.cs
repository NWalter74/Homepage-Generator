using System;
using System.Collections.Generic;

namespace Homepage_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data från ett API
            string[] techniquesList = { " C#", "daTAbaser", "WebbuTVeckling ", "clean Code " };
            string[] medelandeList = { "Måndag idrott", "Tisdag musik", "Onsdag utedag", "Torsdag kör", "Fredag ledig" };          

            //Objekt för att hantera hemsidan
            WebsiteGenerator websiteGenerator = new WebsiteGenerator("klass 5B", techniquesList, medelandeList);

            StyledWebsiteGenerator styledWebsiteGenerator = new StyledWebsiteGenerator("klass 6A", "blue", techniquesList, medelandeList);

            //Utskrivt av hemsidan
            websiteGenerator.printPage();
            Console.WriteLine("----------------------------------------------------------------");
            styledWebsiteGenerator.printPage();

        }
    }
}
