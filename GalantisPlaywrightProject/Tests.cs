using Microsoft.Playwright;

namespace GalantisPlaywrightProject
{
    [TestFixture]
    public class Tests : PageTest
    {
        private Pages pages;
        private Methods methods;        
        private Buttons buttons;                
        private Locators locators;

        [SetUp]
        public void Setup()
        {
            pages = new Pages();  
            locators = new Locators();
            methods = new Methods(Page, pages);
            buttons = new Buttons(methods, locators);
        }

        [Test]
        public async Task GoToMainPage_ShouldPass()
        {
            await methods.GoToMainPage();            
        }

        [Test]
        public async Task CloseMainPageModalWindow_ShouldPass()
        {
            await methods.GoToMainPage();
            await buttons.CloseMainPageModal();
        }
    }
}
