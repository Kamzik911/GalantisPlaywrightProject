namespace GalantisPlaywrightProject
{
    public class Buttons
    {
        private Methods methods;
        private Locators locators;        

        public Buttons(Methods methods, Locators locators)
        {
            this.methods = methods ?? throw new ArgumentNullException(nameof(methods));
            this.locators = locators ?? throw new ArgumentNullException(nameof(locators));
        }

        public async Task CloseMainPageModal()
        {
            await methods.ClickOnElementIfAvailable(locators.CloseButtonMainPageModal);
        }
    }
}
