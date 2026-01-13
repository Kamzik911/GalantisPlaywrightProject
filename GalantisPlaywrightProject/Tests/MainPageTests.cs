using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Locators;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.MainPageTests
{
    [TestFixture]
    public class MainPageTests : PageTest
    {
        private Pages pages;
        private PagesNavigation pageNavi;        
        private DirectPageLinks pageLinks;
        private ElementActions elementAct;        
        private MainPageButtons mpButtons;        

        [SetUp]
        public void Setup()
        {
            pages = new Pages();            
            pageNavi = new PagesNavigation(Page);
            elementAct = new ElementActions(Page);
            mpButtons = new MainPageButtons(elementAct);
            pageLinks = new DirectPageLinks(pageNavi, mpButtons);            
        }

        [Test]
        public async Task GoToMainPage_ShouldPass()
        {
            await pageNavi.GoToMainPage();            
        }

        [Test]
        public async Task CloseMainPageModalWindow_ShouldPass()
        {
            await pageNavi.GoToMainPage();
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
