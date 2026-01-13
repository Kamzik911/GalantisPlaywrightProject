using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.MainPageTests
{
    [TestFixture]
    public class MainPageTests : PageTest
    {
        private Pages pages;
        private IPagesNavigation pageNavi;        
        private IDirectPages pageLinks;
        private IElementActions elementAct;        
        private IMainPageButtons mpButtons;        

        [SetUp]
        public void Setup()
        {
            pages = new Pages();
            pageNavi = new PagesNavigation(Page);
            elementAct = new ElementActions(Page);
            mpButtons = new MainPageButtons(elementAct);
            pageLinks = new DirectPages(pageNavi, mpButtons);            
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
