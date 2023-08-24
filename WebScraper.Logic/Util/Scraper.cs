using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebScraper.Logic.Interfaces;

namespace WebScraper.Logic.Util;

public class Scraper : IScraper
{

    public Scraper(IWebsite website)
    {
        Website = website;
    }

    public IWebsite Website { get; set; }

    public List<IProduct> Scrape(string category)
    {
        List<IProduct> result = new List<IProduct>();

        //Step 0: create chrome driver
        IWebDriver driver = new ChromeDriver();

        //Step 1: driver url. For testing -> category url;
        driver.Url = Website.CategoryUrl;

        IWebElement gpuList = driver.FindElement(By.Id("Product_List"));
        int numberOfChildren = driver.FindElement(By.Id("Product_List")).Count;

        IReadOnlyCollection <IWebElement> child_elements = gpuList.FindElements(By.CssSelector("#Product_List > div:nth-child(4)"));


        foreach (IWebElement childElement in child_elements)
        {
            Console.WriteLine(child_elements.Select(x => x.TagName));
        }

        

        return result;
    }
}
