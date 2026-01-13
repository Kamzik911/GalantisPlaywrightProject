using GalantisPlaywrightProject.Buttons;
using GalantisPlaywrightProject.Locators;

namespace GalantisPlaywrightProject.Setup
{
    public class DirectPages : IDirectPages
    {
        private IPagesNavigation pageNavi;
        private IMainPageButtons mpButtons;        

        public DirectPages(IPagesNavigation pageNavi, IMainPageButtons mpButtons)
        {
            this.pageNavi = pageNavi ?? throw new ArgumentNullException(nameof(pageNavi));            
            this.mpButtons = mpButtons ?? throw new ArgumentNullException(nameof(mpButtons));            
        }            

        public async Task VisitMainPage()
        {
            await pageNavi.GoToMainPage();
            await mpButtons.CloseMainPageModal();
        }
    }   
}
