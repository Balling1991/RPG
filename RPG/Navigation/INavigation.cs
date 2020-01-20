namespace RPG.Navigation
{
    public interface INavigation
    {
        void PrintMainMenu();

        void PrintMainMenuChoices(string choices);

        void PrintGameMenu();
    }
}
