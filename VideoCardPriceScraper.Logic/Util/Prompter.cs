using WebScraper.Logic.Enums;
using static System.Console;

namespace WebScraper.Logic.Util;

public class Prompter
{
    public Tuple<string, string> Prompt()
    {

        WriteLine("Welcome to PC-components Scraping Software!!!");
        WriteLine("");
        WriteLine("Select a site to scrape:");
        int correspondintNumber = 1;
        foreach (string item in Enum.GetNames(typeof(Sources)))
        {
            WriteLine($"{item} - {correspondintNumber}");
            correspondintNumber++;
        }
        string siteInput = Enum.GetName(typeof(Sources), Convert.ToInt32(ReadLine()))!; 
        WriteLine($"Selected source is {siteInput}");
        WriteLine("");
        WriteLine($"Select a category to scrape for:");
        correspondintNumber = 1;
        foreach (string item in Enum.GetNames(typeof(Categories)))
        {
            WriteLine($"{item} - {correspondintNumber}");
            correspondintNumber++;
        }
        string categoryInput = Enum.GetName(typeof(Categories), Convert.ToInt32(ReadLine()))!;
        WriteLine($"Selected category is {categoryInput}");
        WriteLine("");

        var result = Tuple.Create(siteInput, categoryInput);
        return result;
    }
}
