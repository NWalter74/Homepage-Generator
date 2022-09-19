using System;
using System.Collections.Generic;
using System.Text;

namespace Homepage_Generator
{
    //Denna klass ärver från klassen WebsiteGenerator
    class StyledWebsiteGenerator : WebsiteGenerator
    {
        private string color;

        //Konstruktorn har alla egenskaper av basklasen men även en egen (här: color)
        public StyledWebsiteGenerator(string myClassName, string myColor, string[] myTechniqueList, string[] myMedelandeList) : base (myClassName, myMedelandeList, myTechniqueList)
        {
            this.color = myColor;
        }

        //Den nya varianten av metoden header, anpassad just för denna klass. Därav som override
        override protected void header()
        {
            Console.WriteLine("<!DOCTYPE htm >" +
            "           \n<html>" +
            "           \n<head>" +
            "           \n<styles>" +
            "           \np color: " + this.color +
            "           \n</styles>" +
            "           \n</head>" +
            "           \n<body>");
        }
    }
}
