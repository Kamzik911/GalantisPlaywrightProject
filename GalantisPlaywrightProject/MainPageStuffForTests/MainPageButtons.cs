using GalantisPlaywrightProject.Setup;

namespace GalantisPlaywrightProject.MainPageStuff
{
    public class MainPageButtons : IMainPageButtons
    {
        private IElementActions elementActions;
        private MainPageLocators mpLocators;

        public MainPageButtons(IElementActions elementActions)
        {
            this.elementActions = elementActions ?? throw new ArgumentNullException(nameof(elementActions));
            mpLocators = new MainPageLocators();
        }

        public async Task CloseMainPageModal()
        {
            await elementActions.ClickOnElement(mpLocators.CloseButtonMainPageModal);
        }

        public async Task ViewAllButtonIsVisible()
        {
            await elementActions.CheckElementTextVisibility(mpLocators.ViewAllButton);
        }

        public async Task ClickOnSearchButton() 
        {
            await elementActions.ClickOnElement(mpLocators.SearchButton);
        }
    }
}
