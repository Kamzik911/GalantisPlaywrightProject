using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Locators;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.MainPageTests
{
    [TestFixture]
    public class MainPageTests : PageTest
    {
        private Pages pages;
        private Methods methods;
        private DirectPageLinks pageLinks;
        private MainPageButtons mpButtons;                
        private MainPageLocators mplocators;        

        [SetUp]
        public void Setup()
        {
            pages = new Pages();
            mplocators = new MainPageLocators();
            methods = new Methods(Page, pages);
            mpButtons = new MainPageButtons(methods, mplocators);
            pageLinks = new DirectPageLinks(methods, mpButtons);
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
            await mpButtons.CloseMainPageModal();
        }

        [Test]
        public async Task ViewButtonIsVisible()
        {
            await pageLinks.VisitMainPage();
            await mpButtons.ViewAllButtonIsVisible();
        }
    }
}
