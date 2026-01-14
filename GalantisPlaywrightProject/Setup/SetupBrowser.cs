using Microsoft.Playwright;

namespace GalantisPlaywrightProject.Setup
{
    public static class SetupBrowser
    {
        public static async Task<BrowserSession> LaunchChromiumAsync(bool headless = false)
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless
            });

            return new BrowserSession(playwright, browser);
        }
    }

    public sealed class BrowserSession : IAsyncDisposable 
    {
        public BrowserSession(IPlaywright playwright, IBrowser browser)
        {
            Playwright = playwright;
            Browser = browser;
        }

        public IPlaywright Playwright { get; }
        public IBrowser Browser { get; }

        public async ValueTask DisposeAsync()
        {
            await Browser.CloseAsync();
            Playwright.Dispose();
        }
    }
}
