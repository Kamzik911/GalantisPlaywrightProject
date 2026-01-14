using GalantisPlaywrightProject.MainPageStuff;
using GalantisPlaywrightProject.MainPageStuffForTests;
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
        private IMainPageFields mpFields;

        [SetUp]
        public void Setup()
        {
            pages = new Pages();
            pageNavi = new PagesNavigation(Page);
            elementAct = new ElementActions(Page);
            mpButtons = new MainPageButtons(elementAct);
            pageLinks = new DirectPages(pageNavi, mpButtons);
            mpFields = new MainPageFields(elementAct);
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
        public async Task ViewButtonIsVisible_ShouldPass()
        {
            await pageLinks.GoToMainPageWithCloseMainModal();
            await mpButtons.ViewAllButtonIsVisible();
        }

        [Test]
        public async Task ClickOnSearchButton_ShouldPass()
        {
            await pageLinks.GoToMainPageWithCloseMainModal();
            await mpButtons.ClickOnSearchButton();
        }

        [Test]
        public async Task SearchFieldIsVisible_ShouldPass()
        {
            await pageLinks.GoToMainPageWithCloseMainModal();
            await mpButtons.ClickOnSearchButton();
            await mpFields.CheckSearchFieldVisibility();
        }        
    }
}
