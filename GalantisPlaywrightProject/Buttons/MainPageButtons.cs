using GalantisPlaywrightProject.Locators;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.Buttons
{
    public class MainPageButtons
    {
        private Methods methods;
        private MainPageLocators locators;

        public MainPageButtons(Methods methods, MainPageLocators locators)
        {
            this.methods = methods ?? throw new ArgumentNullException(nameof(methods));
            this.locators = locators ?? throw new ArgumentNullException(nameof(locators));
        }

        public async Task CloseMainPageModal()
        {
            await methods.ClickOnElementIfVisible(locators.CloseButtonMainPageModal);
        }

        public async Task ViewAllButtonIsVisible()
        {
            await methods.CheckVisibleTextElement(locators.ViewAllButton);
        }        
    }
}
