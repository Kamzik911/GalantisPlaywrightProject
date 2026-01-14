using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

namespace GalantisPlaywrightProject.Setup
{    
    public class ElementActions : IElementActions
    {
        private readonly IPage page;        
               
        public ElementActions(IPage page)
        {
            this.page = page;            
        }

        public async Task ClickOnElementIfVisible(string selector)
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

        public async Task CheckInputedTextToField(string selector, string text)
        {
            var field = page.Locator(selector);
            await field.WaitForAsync(new() { State = WaitForSelectorState.Visible });
            await Expect(field).ToHaveValueAsync(text);
        }

        public async Task CheckVisibleElementText(string selector)
        {
            var field = page.GetByText(selector);
            await field.WaitForAsync(new() { State = WaitForSelectorState.Visible });            
        }        
    }
}
