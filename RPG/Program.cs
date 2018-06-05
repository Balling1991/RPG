namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (game.IsPlaying)
            {
                game.MainMenu();
            }
        }
    }
}
