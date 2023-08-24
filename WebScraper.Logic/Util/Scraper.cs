using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;
using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Models;

namespace WebScraper.Logic.Util;

public class Scraper : IScraper
{

    public Scraper(IWebsite website)
    {
        Website = website;
    }

    public IWebsite Website { get; set; } 

    public List<IProduct> Scrape()
    {
        List<IProduct> result = new List<IProduct>();


        /* TRUE CODE
        //Step 0: create chrome driver
        IWebDriver driver = new ChromeDriver();

        //Step 1: driver url. For testing -> category url;
        driver.Url = Website.CategoryUrl;

        IWebElement gpuList = driver.FindElement(By.Id("Product_List"));
        //int numberOfChildren = driver.FindElement(By.Id("Product_List")).Count;

        IReadOnlyCollection <IWebElement> child_elements = gpuList.FindElements(By.CssSelector("#Product_List > div:nth-child(4)"));


        foreach (IWebElement childElement in child_elements)
        {
            Console.WriteLine(child_elements.Select(x => x.TagName));
        }

        return result;
        */

        List<VideoCardModel> videoCards = new List<VideoCardModel>
        {
            new VideoCardModel
            {
                DateReleased = "2022-01-15",
                Description = "High-end gaming graphics card",
                Name = "GamerX Pro",
                Price = "$699.99"
            },
            new VideoCardModel
            {
                DateReleased = "2021-09-03",
                Description = "Entry-level graphics card for multimedia use",
                Name = "MediaLite",
                Price = "$149.99"
            },
            new VideoCardModel
            {
                DateReleased = "2023-03-28",
                Description = "Mid-range graphics card with ray tracing support",
                Name = "RayTracer Plus",
                Price = "$449.99"
            },
            new VideoCardModel
            {
                DateReleased = "2022-11-10",
                Description = "Workstation graphics card optimized for professional applications",
                Name = "ProRender Ultra",
                Price = "$899.99"
            },
            new VideoCardModel
            {
                DateReleased = "2023-06-02",
                Description = "Compact form factor graphics card for small PCs",
                Name = "MiniPower GTX",
                Price = "$269.99"
            }
        };

        result.AddRange(videoCards);

        return result;

    }
}
