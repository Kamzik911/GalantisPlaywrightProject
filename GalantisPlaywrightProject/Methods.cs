using Microsoft.Playwright;

namespace GalantisPlaywrightProject
{    
    public class Methods
    {
        private readonly IPage page;
        private readonly Pages pages;             
               
        public Methods (IPage page, Pages pages)
        {
            this.page = page;
            this.pages = pages;
        }

        public async Task GoToMainPage()
        {
            await page.GotoAsync(pages.InitialPage);            
        }

        public async Task<bool> ClickOnElementIfAvailable(string selector)
        {
            if (await page.IsVisibleAsync(selector))
            {
                await page.ClickAsync(selector);
                return true;
            }
            return false;
        }
    }
}
