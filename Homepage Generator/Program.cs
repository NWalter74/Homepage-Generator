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

            WebsiteGenerator websiteGenerator = new WebsiteGenerator("klass 5B", techniquesList, medelandeList);

            //SparaMedelandenIEnList();
            websiteGenerator.printPage();
        }
    }
}
