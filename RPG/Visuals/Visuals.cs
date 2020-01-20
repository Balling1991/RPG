using RPG.Helpers;
using System;
using System.Collections.Generic;

namespace RPG.Visuals
{
    public class Visuals : IVisuals
    {
        public void DrawSplash()
        {
            List<string> splashText = new List<string>()
            {
                { "  _____   _____    _____    _____  _                    _         _               " },
                { " |  __ \\ |  __ \\  / ____|  / ____|(_)                  | |       | |              " },
                { " | |__) || |__) || |  __  | (___   _  _ __ ___   _   _ | |  __ _ | |_  ___   _ __ " },
                { " |  _  / |  ___/ | | |_ |  \\___ \\ | || '_ ` _ \\ | | | || | / _` || __|/ _ \\ | '__|" },
                { " | | \\ \\ | |     | |__| |  ____) || || | | | | || |_| || || (_| || |_| (_) || |   " },
                { " |_|  \\_\\|_|      \\_____| |_____/ |_||_| |_| |_| \\__,_||_| \\__,_| \\__|\\___/ |_|" }
            };

            TextOutputHelper.WriteMultilineInCenter(splashText, ConsoleColor.DarkGreen);
            TextOutputHelper.SetOffset((Console.WindowWidth / 2) - 2, Console.WindowHeight - 5);
            TextOutputHelper.UnderlinedText("PLAY", false);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
