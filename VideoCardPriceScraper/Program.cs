using static System.Console;
using VideoCardPriceScraper.Logic.Enums;
using OpenQA.Selenium;

WriteLine("Welcome to Video-Card Scraping Software!!!");
WriteLine("");
WriteLine("Select a site to scrape:");
int correspondintNumber = 1;
foreach (string item in Enum.GetNames(typeof(Sources)))
{
    WriteLine($"{item} - {correspondintNumber}");
    correspondintNumber++;
}
var input = Enum.Parse(typeof(Sources), ReadLine()!);
WriteLine($"Selected source is {input}");
WriteLine("");
WriteLine($"Select a category to scrape for:");
correspondintNumber = 1;
foreach (string item in Enum.GetNames(typeof(Sources)))
{
    WriteLine($"{item} - {correspondintNumber}");
    correspondintNumber++;
}