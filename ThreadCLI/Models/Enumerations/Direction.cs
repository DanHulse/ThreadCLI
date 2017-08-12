using ThreadCLI.Models.Attributes;

namespace ThreadCLI.Models.Enumerations
{
    public enum Direction
    {
        [Synonym("Forward,Up,Ahead")]
        North = 1,

        [Synonym("Right")]
        East = 2,

        [Synonym("Backward,Back,Down,Behind")]
        South = 4,

        [Synonym("Left")]
        West = 8,

        [Synonym("North East")]
        NorthEast = 16,

        [Synonym("South East")]
        SouthEast = 32,

        [Synonym("South West")]
        SouthWest = 64,

        [Synonym("North West")]
        NorthWest = 128,
    }
}
