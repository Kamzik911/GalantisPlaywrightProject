namespace GalantisPlaywrightProject.Setup
{
    public interface IElementActions
    {
        Task ClickOnElement(string selector);
        Task InputTextToField(string selector, string text);
        Task CheckInputedTextToField(string selector, string text);
        Task CheckElementVisibility(string selector);
        Task CheckElementTextVisibility(string selector);
    }

    public interface IPagesNavigation
    {
        Task GoToMainPage();
    }

    public interface IMainPageButtons 
    {
        Task CloseMainPageModal();        
        Task ViewAllButtonIsVisible();        
        Task ClickOnSearchButton();
    }

    public interface IDirectPages
    {
        Task GoToMainPageWithCloseMainModal();    }

    public interface IMainPageFields
    {
        Task CheckSearchFieldVisibility();
    }
}
