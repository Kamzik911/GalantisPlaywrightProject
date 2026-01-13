using Microsoft.Playwright;

namespace GalantisPlaywrightProject.Setup
{
    public class PagesNavigation
    {
        private readonly IPage page;
        private readonly Pages pages;

        public PagesNavigation(IPage page) 
        {
            this.page = page;
            pages = new Pages();
        }
        public async Task GoToMainPage()
        {
            await page.GotoAsync(pages.InitialPage);
        }
    }
}
