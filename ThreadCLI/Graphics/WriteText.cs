using System;
using ThreadCLI.Helpers;

namespace ThreadCLI.Graphics
{
    public static class WriteText
    {
        public static void Display(string[] textBlock, ColourPalette colourPalette)
        {
            Console.ForegroundColor = colourPalette.primaryColour;
            Console.BackgroundColor = colourPalette.secondaryColour;

            foreach (var text in textBlock)
            {
                var splitString = text.ParseString("*", "*");

                var test = text.Replace("*", string.Empty).Split(new string[] { splitString }, StringSplitOptions.None);

                Console.Write(test[0]);

                if (test.GetLength(0) > 1)
                {

                    Console.ForegroundColor = colourPalette.highlightColour;
                    Console.Write(splitString);

                    Console.ForegroundColor = colourPalette.primaryColour;
                    Console.Write(test[1]);
                }

                Console.Write("\n");
            }

            Console.ResetColor();
        }

        public static void Display(string text, ColourPalette colourPalette)
        {
            Console.ForegroundColor = colourPalette.primaryColour;
            Console.BackgroundColor = colourPalette.secondaryColour;

            var splitString = text.ParseString("*", "*");

            var test = text.Replace("*", string.Empty).Split(new string[] { splitString }, StringSplitOptions.None);

            Console.Write(test[0]);

            if (test.GetLength(0) > 1)
            {

                Console.ForegroundColor = colourPalette.highlightColour;
                Console.Write(splitString);

                Console.ForegroundColor = colourPalette.primaryColour;
                Console.Write(test[1]);
            }

            Console.Write("\n");
            Console.ResetColor();
        }
    }
}
