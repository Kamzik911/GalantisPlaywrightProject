using GalantisPlaywrightProject.Locators;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.Buttons
{
    public class MainPageButtons
    {
        private ElementActions elementActions;
        private MainPageLocators mpLocators;

        public MainPageButtons(ElementActions elementActions)
        {
            this.elementActions = elementActions ?? throw new ArgumentNullException(nameof(elementActions));
            mpLocators = new MainPageLocators();
        }

        public async Task CloseMainPageModal()
        {
            await elementActions.ClickOnElementIfVisible(mpLocators.CloseButtonMainPageModal);
        }

        public async Task ViewAllButtonIsVisible()
        {
            await elementActions.CheckVisibleTextElement(mpLocators.ViewAllButton);
        }        
    }
}
