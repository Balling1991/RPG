using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RPG.Helpers
{
    public static class TextOutputHelper
    {
        const int STD_OUTPUT_HANDLE = -11;
        const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;
        private const string RESET = "\x1b[0m";
        private const string BRIGHT = "\x1b[1m";
        private const string DIM = "\x1b[2m";
        private const string UNDERLINE = "\x1b[4m";
        private const string BLINK = "\x1b[5m";

        private const string CYAN = "\x1b[36;1m";
        private const string RED = "\x1b[31;1m";

        public static void GoToBottomLine(bool defaultCursorPosition)
        {
            Console.CursorTop = Console.WindowTop + Console.WindowHeight - 2;

            if (defaultCursorPosition)
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        }

        public static void WriteTextInCenter(string text)
        {
            SetOffset((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) - 5);
            Console.Write(text);
        }

        public static void WriteTextInCenter(string text, ConsoleColor color)
        {
            SetOffset((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2) - 5);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteMultilineInCenter(List<string> texts, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            int nextLine = 0;

            foreach(var text in texts)
            {
                SetOffset((Console.WindowWidth / 4) - 8, (Console.WindowHeight / 2) - 5 + nextLine);
                Console.WriteLine(text);
                nextLine++;
            }
            Console.ResetColor();
        }

        public static void UnderlinedText(string text, bool newLine)
        {
            SetConsoleMode();

            if (newLine)
                Console.WriteLine(UNDERLINE + text + RESET);
            else
                Console.Write(UNDERLINE + text + RESET);
        }

        public static void FramePattern()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("+");
            builder.Append('-', Console.WindowWidth - 2);
            builder.Append("+");

            Console.WriteLine(builder.ToString());
        }

        public static void BottomFramePattern()
        {
            GoToBottomLine(false);
            FramePattern();
        }

        public static void MenuPrinter(string[] menu)
        {
            for (int i = 0; i < menu.Length; i++)
            {
                if (i == 0)
                {
                    SetOffset((Console.WindowWidth / 2 - (menu[i].Length / 2)), (Console.WindowHeight / 4) - 5);
                    UnderlinedText(menu[i], false);
                }
                else if (i == 1)
                {
                    string entry = "[" + CYAN + $"{i}" + RESET + "] " + menu[i];
                    int calcLength = ($"[{i}]" + menu[i]).Length;

                    SetOffset((Console.WindowWidth / 2 - (calcLength / 2)), (Console.WindowHeight / 3));
                    Console.WriteLine(entry);
                }
                else if (1 < i && i < menu.Length - 1)
                {
                    string entry = "[" + CYAN + $"{i}" + RESET + "] " + menu[i];
                    int calcLength = ($"[{i}]" + menu[i]).Length;

                    SetOffset((Console.WindowWidth / 2 - (calcLength / 2)), (Console.WindowHeight / 3) + 1);
                    Console.WriteLine(entry);
                }
                else
                {
                    string entry = "[" + RED + "Q" + RESET + "] " + menu[i];
                    int calcLength = ("[Q]" + menu[i]).Length; 

                    SetOffset((Console.WindowWidth / 2 - (calcLength / 2)), (Console.WindowHeight / 3) + 3);
                    Console.WriteLine(entry);
                }
            }
        }

        public static void SetOffset(int leftOffset, int topOffset)
        {
            Console.SetCursorPosition(leftOffset, topOffset);
        }

        public static void SetTopOffset(int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth, offset);
        }

        public static void SetLeftOffset(int offset)
        {
            Console.SetCursorPosition(offset, Console.WindowHeight);
        }

        private static void SetConsoleMode()
        {
            var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            GetConsoleMode(handle, out uint mode);
            mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
            SetConsoleMode(handle, mode);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
    }
}
