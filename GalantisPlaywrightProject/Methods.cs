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

        public async Task ClickOnElementIfAvailable(string selector)
        {
            var field = page.Locator(selector);
            await field.WaitForAsync(new() { State = WaitForSelectorState.Visible });
            await field.ClickAsync();
        }

        public async Task InputTextToField(string selector, string text)
        {            
            var field = page.Locator(selector);
            await field.WaitForAsync(new() { State = WaitForSelectorState.Visible });
            await field.FillAsync(text);            
        }
    }
}
