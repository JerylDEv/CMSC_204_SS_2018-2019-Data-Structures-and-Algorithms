using MyClassLibrary;
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
*/

namespace ConsoleAppNETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a myScrape object instance of Scrape Class */
            Scrape myScrape = new Scrape();

            /*
             * Notice that after adding the MyClassLibrary namespace, the MyClassLibrary.dll will be added in the debug folder
             * C:\Users\accessadmin\Documents\2 - UPOU\CMSC 204\C# Basics\15 - Creating and adding references to assemblies\ConsoleAppNETFramework\ConsoleAppNETFramework\bin\Debug
             */

            string value = myScrape.ScrapeWebpage("https://jeryldev.com");

            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
