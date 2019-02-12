using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            string webContent = GetWebpage(url);
            return webContent;
            
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string webContent = GetWebpage(url);

            File.WriteAllText(filepath, webContent);
            return webContent;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
