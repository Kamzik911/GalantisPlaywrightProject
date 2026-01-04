using Microsoft.Playwright;

namespace GalantisPlaywrightProject
{    
    public class Methods : PageTest
    {
        private readonly IPage page;
        private readonly Pages pages;             
               
        public Methods (IPage page, Pages pages)
        {
            this.page = page;
            this.pages = pages;
        }

        //Browser
        public async Task SelectedChromeBrowser()
        {            
            await using var browser = await Playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
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
