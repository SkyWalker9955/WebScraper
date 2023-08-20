using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;
using OpenQA.Selenium.Chrome;

Prompter prompter = new();
// Use UrlIdentifier
Tuple<string, string> userInput = prompter.Prompt();
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples#tuples-vs-systemtuple

URLIdentifier urlIdentifier = new(userInput);

Website website = new(userInput.Item1, urlIdentifier._baseUrl, urlIdentifier._categoryUrl);

Scraper scraper = new(website);
