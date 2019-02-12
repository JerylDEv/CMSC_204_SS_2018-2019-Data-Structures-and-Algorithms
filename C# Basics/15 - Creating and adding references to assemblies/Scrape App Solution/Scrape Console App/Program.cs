using My_Scrape_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
To add an Assemblies in Visual Studio 2017:
1. Go to Solutions Explorer
2. Right-Click on References
3. Select Add Reference...
4. Select the Reference by checking the box under the Targeting column
5. Click Ok
*/

/*
To add 3rd Party Assemblies, we can use Nuget or NPM.
To work with Nuget visually in Visual Studio 2017:
1. Navigate to Tools > Nuget Package Manager > Manage Nuget Packages for Solution...
2. Select the Nuget Package to Install
3. Select the Project in which we want to install the Nuget Package
4. Click Install
5. Accept the Terms and Agreements.
6. Wait for the installation to finish.
*/

/*
To add a reference to a Class Library which we created:
1. Go to Solutions Explorer
2. Right-Click on References
3. Select Add Reference...
4. Select Browse, and click the Browse button.
5. Search for the Class Library folder > bin > Release sub folder.
6. Select  the .dll file (in my case it was MyClassLibrary.dll)
7. Click Ok.

Note: If the Project is in the same solution as the Class Library, 
then we should be able to see the Class Library when we select "Solution" in Step 4 instead of "Browse".
*/


/* Right-click on the "Scrape Console App" Project > then click, Set as StartUp Project */
namespace Scrape_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Webpage HTML Scraper Console App";

            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();

            Console.WriteLine("This is a Webpage HTML scraper console application.");
            Console.WriteLine(" ");
            Console.WriteLine("Please make sure to connect to the internet when using this application.");
            Console.WriteLine(" ");
            Console.WriteLine("Choose the action you want to perform:");
            Console.WriteLine("1) View the HTML of a specific webpage");
            Console.WriteLine("2) Download the HTML of a specific webpage.");
            Console.WriteLine("3) Exit.");
            Console.WriteLine(" ");
            Console.Write("Action selected: \t");
            string actionSelected = Console.ReadLine();

            if (actionSelected == "1")
            {
                ViewHTML();
                return false;
            }
            else if (actionSelected == "2")
            {
                DownloadHTML();
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void ViewHTML()
        {
            Console.Clear();

            /* Create a myScrape object instance of Scrape Class */
            Scrape myScrape = new Scrape();

            /*
             * Notice that after adding the MyClassLibrary namespace, the MyClassLibrary.dll will be added in the debug folder
             * C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\15 - Creating and adding references to assemblies\ConsoleAppNETFramework\ConsoleAppNETFramework\bin\Debug
             */
            
            Console.WriteLine("Enter the Web page URL whose HTML content would you like to view.");
            Console.WriteLine(" ");
            Console.WriteLine("Please make sure to connect to the internet when using this application.");
            Console.WriteLine(" ");
            Console.Write("Enter the URL (i.e. https://jeryldev.com): \t");
            string value = myScrape.ScrapeWebpage(Console.ReadLine());

            Console.WriteLine(" ");           
            Console.WriteLine(value);
            Console.WriteLine(" ");

            Console.ReadLine();
        }

        private static void DownloadHTML()
        {
            Console.Clear();

            Scrape myScrape = new Scrape();

            Console.WriteLine("Enter the Web page URL whose HTML content would you like to download");
            Console.WriteLine("and the folder filepath to which you want to save the \"HTML.txt\" file.");
            Console.WriteLine(" ");
            Console.WriteLine("Please make sure to connect to the internet when using this application.");
            Console.WriteLine(" ");

            Console.Write("Enter the URL (i.e. https://jeryldev.com): \t");
            string webpage = Console.ReadLine();

            Console.Write("Enter the folder filepath (i.e. C:\\Users\\accessadmin\\Downloads\\): \t");
            string filepath = Console.ReadLine();
            string filepathAndFile = $"{filepath}HTML.txt";

            myScrape.ScrapeWebpage(webpage, filepathAndFile);

            Console.WriteLine(" ");
            Console.WriteLine($"Please check your {filepath} if HTML.txt is successfully created.");
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
