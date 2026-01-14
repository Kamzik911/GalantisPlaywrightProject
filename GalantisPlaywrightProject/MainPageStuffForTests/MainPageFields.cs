using GalantisPlaywrightProject.MainPageStuff;
using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.MainPageStuffForTests
{
    public class MainPageFields : IMainPageFields
    {
        private IElementActions elementActions;
        private MainPageLocators mpLocators;

        public MainPageFields(IElementActions elementActions) 
        {
            this.elementActions = elementActions ?? throw new ArgumentNullException(nameof(elementActions));
            mpLocators = new MainPageLocators();
        }

        public async Task CheckSearchFieldVisibility()
        {
            await elementActions.CheckVisibleElementText(mpLocators.MainPageSearchField);
        }
    }
}
