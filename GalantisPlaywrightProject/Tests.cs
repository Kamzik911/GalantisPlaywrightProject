using Microsoft.Playwright;

namespace GalantisPlaywrightProject
{
    [TestFixture]
    public class Tests : PageTest
    {
        private Methods methods;
        private Locators locators;
        private Pages pages;

        [SetUp]
        public void Setup()
        {
            pages = new Pages();
            locators = new Locators();
            methods = new Methods(Page, pages);
        }

        [Test]
        public async Task GoToMainPage_ShouldPass()
        {
            await methods.GoToMainPage();
            await methods.ClickOnElementIfAvailable(locators.CloseButtonMainPageModal);
        }
    }
}
