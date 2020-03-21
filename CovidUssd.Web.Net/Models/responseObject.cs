using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidUssd.Web.Net.Models
{
    public static class responseObject
    {
        static string response;



        public static string Menu(string text)
        {

            if (text.Equals("", StringComparison.Ordinal))
            {
                response = "Con Covid-19 information platform powered by code360 \n Press any number to get informate\n";

                response += "1. Wetin be corona virus?\n";
                response += "2. Wetin we go see, know sey we get am?\n";
                response += "3. How e take dey enter person body?\n";
                response += "4. Wetin I go do make i no get am?\n";
                response += "5. If I get am wetin I go do?\n";
                response += "6. Numbers wey i fit call for help or question.\n";


            }
            else if (text.Equals("1", StringComparison.Ordinal))
            {
                response = "END Di virus, wey dem don officially name Covid-19, na new strain of coronavirus wey dem neva see for human body before. Di virus fit affect di lungs, and cause cold and catarrh. E fit spread from pesin to pesin through coughing and sneezing\n";
            }
            else if (text.Equals("2", StringComparison.Ordinal))
            {
                response = "END Di main symptoms include To carry air pass nose put for body go hard \n Fever \nCoughing and sneezing.\nE fit also lead to organ failurePneumoniaAnd Death \n";
            }
            else if (text.Equals("3", StringComparison.Ordinal))
            {
                response = "END Some other thing has been done \n";
            }
            else if (text.Equals("4", StringComparison.Ordinal))
            {
                response = "END Some other thing has been done \n";
            }
            else if (text.Equals("5", StringComparison.Ordinal))
            {
                response = "END Some other thing has been done \n";
            }
            else if (text.Equals("6", StringComparison.Ordinal))
            {
                response = "END Some other thing has been done \n";
            }
            else
            {
                response = "END Invalid option \n";
            }

            return response;

        }
    }
}