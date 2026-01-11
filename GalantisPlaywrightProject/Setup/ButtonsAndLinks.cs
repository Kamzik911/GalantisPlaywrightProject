using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Locators;

namespace GalantisPlaywrightProject.Setup
{
    public class DirectPageLinks
    {
        private Methods methods;
        private MainPageButtons mpButtons;        

        public DirectPageLinks(Methods methods, MainPageButtons mpButtons)
        {
            this.methods = methods ?? throw new ArgumentNullException(nameof(methods));            
            this.mpButtons = mpButtons ?? throw new ArgumentNullException(nameof(mpButtons));            
        }            

        public async Task VisitMainPage()
        {
            await methods.GoToMainPage();
            await mpButtons.CloseMainPageModal();
        }
    }

    public class ButtonsAndLinks
    {
        private Methods methods;
        private MainPageLocators locators;        

        public ButtonsAndLinks(Methods methods, MainPageLocators locators)
        {
            this.methods = methods ?? throw new ArgumentNullException(nameof(methods));
            this.locators = locators ?? throw new ArgumentNullException(nameof(locators));
        }                
    }
}
