using WebScraper.Logic.Enums;
using static System.Console;

namespace WebScraper.Logic;

public class Prompter
{
    public (string, string) Prompt() {

        WriteLine("Welcome to Video-Card Scraping Software!!!");
        WriteLine("");
        WriteLine("Select a site to scrape:");
        int correspondintNumber = 1;
        foreach (string item in Enum.GetNames(typeof(Sources)))
        {
            WriteLine($"{item} - {correspondintNumber}");
            correspondintNumber++;
        }
        var siteInput = Enum.Parse(typeof(Sources), ReadLine()!);
        WriteLine($"Selected source is {siteInput}");
        WriteLine("");
        WriteLine($"Select a category to scrape for:");
        correspondintNumber = 1;
        foreach (string item in Enum.GetNames(typeof(Categories)))
        {
            WriteLine($"{item} - {correspondintNumber}");
            correspondintNumber++;
        }
        var categoryInput = Enum.Parse(typeof(Categories), ReadLine()!);
        WriteLine($"Selected category is {categoryInput}");
        WriteLine("");

        return ((string)siteInput, (string)categoryInput);
    }
}
