using WebScraper.Logic.Util;
using Xunit;

namespace WebScraper.Test
{
    public class PrompterTest
    {
        [Fact]
        public void PrompterReturnsSiteAndCategoryStrings()
        {
            Prompter prompter = new();
            (string site, string category) result = prompter.Prompt();

            Assert.Equal(typeof(string), result.site.GetType());
            Assert.Equal(typeof(string), result.category.GetType());
        }
    }
}