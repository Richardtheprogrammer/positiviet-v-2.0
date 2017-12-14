using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Media;
namespace positivitet_V_2._0
{
    class Program
    {
        //languages
        private static ResourceSet _resource;
        private static string _currrentLanguage;
        //START COMMANDS
        static void Main(string[] args)
        {

            SetLanguage("sv-SE");
            //SetLanguage("en-us");
            Console.Clear();
            STARTCOMMAND();
            MONGO_START();

        }
        //START COMMANDS ENDS

        private static void MONGO()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            SetLanguage("en-US");
            Console.WriteLine(GetStringValue("Menu_Color"));
            var c = new CultureInfo("sv-SE");
            SetLanguage("sv-SE");
            Console.WriteLine(GetStringValue("Menu_Color"));
            SetLanguage("fr-FR");
            Console.WriteLine(GetStringValue("Menu_Color"));
            SetLanguage("nb-NO");
            Console.WriteLine(GetStringValue("Menu_Color"));

            Console.ReadLine();

        }

        private static void SetLanguage(string language)
        {
           
            _resource = positivitet_V_2._0.Resources.Resources.ResourceManager.GetResourceSet(new CultureInfo(language), true, true);
            _currrentLanguage = language;
        }

        private static string GetStringValue(string input)
        {
            return _resource.GetString(input);
        }
        //Languages ends

            //START MENU
        static void MONGO_START()
        {
            Console.Clear();
            Console.WriteLine(@" .----------------.  .----------------.  .-----------------. .----------------.  .----------------.");
            Console.WriteLine(@"| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |");
            Console.WriteLine(@"| | ____    ____ | || |     ____     | || | ____  _____  | || |    ______    | || |     ____     | |");
            Console.WriteLine(@"| ||_   \  /   _|| || |   .'    `.   | || ||_   \|_   _| | || |  .' ___  |   | || |   .'    `.   | |");
            Console.WriteLine(@"| |  |   \/   |  | || |  /  .--.  \  | || |  |   \ | |   | || | / .'   \_|   | || |  /  .--.  \  | |");
            Console.WriteLine(@"| |  | |\  /| |  | || |  | |    | |  | || |  | |\ \| |   | || | | |    ____  | || |  | |    | |  | |");
            Console.WriteLine(@"| | _| |_\/_| |_ | || |  \  `--'  /  | || | _| |_\   |_  | || | \ `.___]  _| | || |  \  `--'  /  | |");
            Console.WriteLine(@"| ||_____||_____|| || |   `.____.'   | || ||_____|\____| | || |  `._____.'   | || |   `.____.'   | |");
            Console.WriteLine(@"| |              | || |              | || |              | || |              | || |              | |");
            Console.WriteLine(@"| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |"); 
            Console.WriteLine(@" '----------------'  '----------------'  '----------------'  '----------------'  '----------------' ");
            

            Console.WriteLine("", Encoding.UTF8);
            Console.WriteLine($"1){GetStringValue("Menu_Settings")}");
            Console.WriteLine($"2){GetStringValue("Menu_Credit")}");
            Console.WriteLine($"3){GetStringValue("Menu_Github")}");
            Console.WriteLine($"4){GetStringValue("Menu_Music")}");
            Console.WriteLine($"5){GetStringValue("Menu_Bugs")}");
            Console.WriteLine($"6){GetStringValue("Menu_ContactME")}");
            Console.WriteLine($"7){GetStringValue("Menu_AboutME")}");
            Console.WriteLine($"8){GetStringValue("Menu_Language")}");

            var input = Console.ReadLine().Trim();
            MONGO_START_MENU(input);

        }
        //START ENDS

        static void MONGO_START_MENU(string input)
        {
            switch(input)
            {
                case "1":
                    Console.Clear();
                    SETTINGS();

                    break;

                case "2":
                    Console.Clear();
                    CREDIT();

                    break;

                case "3":
                    Console.Clear();
                    GITHUB();

                    break;

                case "4":
                    Console.Clear();
                    MUSIC();

                    break;

                case "5":
                    Console.Clear();
                    BUGS();

                    break;

                case "6":
                    Console.Clear();
                    CONTACT_ME();
                    break;

                case "7":
                    Console.Clear();
                    ABOUT_ME();
                    break;

                case "8":
                    Console.Clear();
                    LANGUAGE();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("använd endast de siffror som står där");
                    Console.WriteLine("please use only the numbers u can see in menu");
                    Console.ReadKey(true);
                    Console.Clear();
                    MONGO_START();
                    break;
                    

            }


        }
        //WINDOW AT START
        static void STARTCOMMAND()
        {
            Console.WindowHeight = 32;
            Console.WindowWidth = 105;

        }
        //

        //SETTINGS//
        static void SETTINGS()
        {
            Console.Clear();
            Console.WriteLine("1)color");
            Console.WriteLine("2)height");
            Console.WriteLine("3)width");
            Console.WriteLine("4)format");
            Console.WriteLine("5)back");
            var input = Console.ReadLine().Trim();
            SSETTINGS(input);

        }

        static void SSETTINGS(string input)
        {
            switch(input)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    break;

            }
        }

        //

        //CREDIT
        static void CREDIT()
        {

        }
        //

        //GITHUB
        static void GITHUB()
        {

        }
        //

        //MUSIC
        static void MUSIC()
        {

        }
        //

        //BUGS
        static void BUGS()
        {

        }
        //

       //CONTACT ME
       static void CONTACT_ME()
        {

        }
        //

        //ABOUT ME
        static void ABOUT_ME()
        {

        }
        //

        //LANGUAGE
        static void LANGUAGE()
        {
            Console.Clear();
            if (_currrentLanguage == "en-US")
            {
                SetLanguage("sv-SE");
            }
            else
            {
                SetLanguage("en-US");
            }
            MONGO_START();
        }
        //


    }
}
