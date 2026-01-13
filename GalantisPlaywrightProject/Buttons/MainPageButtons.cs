using GalantisPlaywrightProject.Locators;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.Buttons
{
    public class MainPageButtons
    {
        private ElementActions elementActions;
        private MainPageLocators locators;

        public MainPageButtons(ElementActions elementActions)
        {
            this.elementActions = elementActions ?? throw new ArgumentNullException(nameof(elementActions));            
        }

        public async Task CloseMainPageModal()
        {
            await elementActions.ClickOnElementIfVisible(locators.CloseButtonMainPageModal);
        }

        public async Task ViewAllButtonIsVisible()
        {
            await elementActions.CheckVisibleTextElement(locators.ViewAllButton);
        }        
    }
}
