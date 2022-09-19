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

            for (int i = 0; i<techniquesList.Length; i++)
            {
                techniquesList[i] = techniquesList[i].Trim().ToLower();
                techniquesList[i] = techniquesList[i][0].ToString().ToUpper() + techniquesList[i].Substring(1);                
            }

            WebsiteGenerator websiteGenerator = new WebsiteGenerator(techniquesList, medelandeList);

            //SparaMedelandenIEnList();
            websiteGenerator.header();
            websiteGenerator.mainPart("klass 5B", techniquesList, medelandeList);
            websiteGenerator.footer();
        }
    }
}
