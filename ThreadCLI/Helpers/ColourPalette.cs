using System;

namespace ThreadCLI.Helpers
{
    /// <summary>
    /// Class containing the colour palette
    /// </summary>
    public class ColourPalette
    {
        /// <summary>
        /// The primary colour
        /// </summary>
        public ConsoleColor primaryColour;

        /// <summary>
        /// The secondary colour
        /// </summary>
        public ConsoleColor secondaryColour;

        /// <summary>
        /// The highlight colour
        /// </summary>
        public ConsoleColor highlightColour;
    }

    /// <summary>
    /// The specific color palettes of available
    /// </summary>
    public static class ColourPalettes
    {
        /// <summary>
        /// The primary colour palette
        /// </summary>
        public static ColourPalette Primary = new ColourPalette { primaryColour = ConsoleColor.White, secondaryColour = ConsoleColor.Black, highlightColour = ConsoleColor.Cyan };

        /// <summary>
        /// The secondary colour palette
        /// </summary>
        public static ColourPalette Secondary = new ColourPalette { primaryColour = ConsoleColor.Black, secondaryColour = ConsoleColor.White, highlightColour = ConsoleColor.Yellow };

        /// <summary>
        /// The header colour palette
        /// </summary>
        public static ColourPalette Header = new ColourPalette { primaryColour = ConsoleColor.White, secondaryColour = ConsoleColor.DarkBlue, highlightColour = ConsoleColor.DarkCyan };
    }
}
