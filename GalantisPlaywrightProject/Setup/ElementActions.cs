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

        public async Task ClickOnElement(string selector)
        {
            var field = page.Locator(selector);            
            await field.ClickAsync();
        }

        public async Task CheckElementVisibility(string selector)
        {
            await Expect(page.Locator(selector)).ToBeVisibleAsync();
        }

        public async Task CheckElementTextVisibility(string selector)
        {
            await Expect(page.GetByRole(AriaRole.Link, new() { Name = selector})).ToBeVisibleAsync();
        }

        public async Task InputTextToField(string selector, string text)
        {            
            var field = page.Locator(selector);            
            await field.FillAsync(text);            
        }

        public async Task CheckInputedTextToField(string selector, string text)
        {
            var field = page.Locator(selector);            
            await Expect(field).ToHaveValueAsync(text);
        }                        
    }
}
