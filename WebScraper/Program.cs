using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;
using OpenQA.Selenium.Chrome;

Prompter prompter = new();
// Use UrlIdentifier
Tuple<string, string> userInput = prompter.Prompt();
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples#tuples-vs-systemtuple

URLIdentifier urlIdentifier = new(userInput);

Website website = new(userInput.Item1, urlIdentifier._baseUrl, "https://www.newegg.com/Everyday-Saving-Trending-Deals/EventSaleStore/ID-9447?N=100006662&cm_sp=Tab_Components-_-Flyout-_-Deals-by-Categroy-_-Video-Cards-Video-Devices");

Scraper scraper = new(website);

//scraper.Scrape(website.CategoryUrl);
