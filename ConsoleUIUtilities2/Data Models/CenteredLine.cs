﻿namespace ConsoleUIUtilities2
{
    internal static class CenteredLine
    {
        public static void PrintToConsole(string text, int row, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, row);
            Console.ForegroundColor = color; 
            Console.Write(text);
            Console.ResetColor(); 
        }
    }
}