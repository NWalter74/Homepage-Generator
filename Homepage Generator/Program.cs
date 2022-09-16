using System;
using System.Collections.Generic;

namespace Homepage_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteGenerator websiteGenerator = new WebsiteGenerator();

            //SparaMedelandenIEnList();
            websiteGenerator.header();
            websiteGenerator.mainPart("klass 5B");
            websiteGenerator.footer();
        }
    }
}
