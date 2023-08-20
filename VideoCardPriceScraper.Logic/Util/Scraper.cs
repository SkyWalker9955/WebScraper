using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logic.Util;

public class Scraper : IScraper
{
    public IWebsite Website => throw new NotImplementedException();

    public string CategoryToScrape => throw new NotImplementedException();

    public List<IProduct> Scrape(string category)
    {
        throw new NotImplementedException();
    }
}
