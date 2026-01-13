namespace GalantisPlaywrightProject.Setup
{
    public interface IElementActions
    {
        Task ClickOnElementIfVisible(string selector);
        Task InputTextToField(string selector, string text);
        Task CheckVisibleTextElement(string selector);
    }

    public interface IPagesNavigation
    {
        Task GoToMainPage();
    }

    public interface IMainPageButtons 
    {
        Task CloseMainPageModal();
        Task ViewAllButtonIsVisible();
    }

    public interface IDirectPages
    {
        Task VisitMainPage();
    }
}
