namespace ThreadCLI.Models.Enumerations
{
    /// <summary>
    /// Specifies if the draw location should be based on the current cursor location or the top of the window.
    /// </summary>
    public enum DrawKind
    {
        /// <summary>
        /// The below cursor draw type
        /// </summary>
        BelowCursor,

        /// <summary>
        /// The below cursor but keep cursor location draw type
        /// </summary>
        BelowCursorButKeepCursorLocation,

        /// <summary>
        /// From top draw type
        /// </summary>
        FromTop,
    }
}
