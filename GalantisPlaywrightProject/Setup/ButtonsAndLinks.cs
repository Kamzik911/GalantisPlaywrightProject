using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Locators;

namespace GalantisPlaywrightProject.Setup
{
    public class DirectPageLinks
    {
        private PagesNavigation pageNavi;
        private MainPageButtons mpButtons;        

        public DirectPageLinks(PagesNavigation pageNavi, MainPageButtons mpButtons)
        {
            this.pageNavi = pageNavi ?? throw new ArgumentNullException(nameof(pageNavi));            
            this.mpButtons = mpButtons ?? throw new ArgumentNullException(nameof(mpButtons));            
        }            

        public async Task VisitMainPage()
        {
            await pageNavi.GoToMainPage();
            await mpButtons.CloseMainPageModal();
        }
    }

    public class ButtonsAndLinks
    {
        private ElementActions elementAct;
        private MainPageLocators locators;        

        public ButtonsAndLinks(ElementActions elementAct, MainPageLocators locators)
        {
            this.elementAct = elementAct ?? throw new ArgumentNullException(nameof(elementAct));
            this.locators = locators ?? throw new ArgumentNullException(nameof(locators));
        }                
    }
}
